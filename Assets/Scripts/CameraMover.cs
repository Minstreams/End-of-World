using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这个就放在主摄像机上吧
/// </summary>
[DisallowMultipleComponent]
public class CameraMover : MonoBehaviour
{
    /// <summary>
    /// 设置类
    /// </summary>
    [System.Serializable]
    public struct Setting
    {
        [Range(0.01f, 1)]
        public float 移动缓动值;
        [Range(0.01f, 1)]
        public float 旋转缓动值;
    }
    /// <summary>
    /// 设置
    /// </summary>
    private static Setting setting;
    /// <summary>
    /// 关联的相机
    /// </summary>
    private static Camera mainCam;
    private static CameraMover mover;
    //相机默认设置
    private static float origFieldOfView;
    private static Vector3 origPosition;
    private static Quaternion origRotation;
    private static Color origBackgroundColor;
    private static Vector3 TVcamPosition;
    private static Quaternion TVcamRotation;
    private static Material TVmat;
    private static float sqrtDistance;


    /************
     * 内部方法 *
     ************/
    private void Start()
    {
        setting = GameSystem.settings.相机设置;
        mainCam = GetComponent<Camera>();
        origFieldOfView = mainCam.fieldOfView;
        origPosition = transform.position;
        origRotation = transform.rotation;
        origBackgroundColor = mainCam.backgroundColor;
        mover = this;
    }

    //移动
    private static IEnumerator moveTo(TVScreen target)
    {
        TVcamPosition = target.camPoint.position;
        TVcamRotation = target.camPoint.rotation;
        TVmat = target.material;
        sqrtDistance = (TVcamPosition - origPosition).sqrMagnitude;

        yield return moveToPoint(TVcamPosition, TVcamRotation, false);
        SetCamera(target.cam);
        mover.transform.position = target.cam.transform.position;
        mover.transform.rotation = target.cam.transform.rotation;
        yield return 0;
    }
    //返回
    private static IEnumerator moveBack()
    {
        mover.transform.position = TVcamPosition;
        mover.transform.rotation = TVcamRotation;
        SetCamera(null);
        sqrtDistance = (TVcamPosition - origPosition).sqrMagnitude;

        yield return moveToPoint(origPosition, origRotation, true);
        yield return 0;
    }
    private static IEnumerator moveToPoint(Vector3 targetPos, Quaternion targetRot, bool ifBack = false)
    {
        Vector3 delta = targetPos - mover.transform.position;
        float deltaSqrtDis = delta.sqrMagnitude;
        if (deltaSqrtDis < 0.1f)
        {
            mover.transform.position = targetPos;
            mover.transform.rotation = targetRot;
            TVmat.SetFloat("_progress", ifBack ? 0 : 1);
            yield return 0;
        }
        else
        {
            float progress = deltaSqrtDis / sqrtDistance;
            if (!ifBack)
            {
                progress = 1 - progress;
            }
            mover.transform.Translate(delta * setting.移动缓动值);
            mover.transform.rotation = Quaternion.Slerp(mover.transform.rotation, targetRot, setting.旋转缓动值);
            TVmat.SetFloat("_progress", progress);
            yield return 0;
            yield return moveToPoint(targetPos, targetRot, ifBack);
        }
    }

    /// <summary>
    /// 更改相机设置
    /// </summary>
    /// <param name="sets"></param>
    private static void SetCamera(Camera sets)
    {
        if (sets == null)
        {
            //重置设置
            mainCam.orthographic = false;
            mainCam.fieldOfView = origFieldOfView;
            mainCam.backgroundColor = origBackgroundColor;
        }
        else
        {
            mainCam.orthographic = true;
            mainCam.orthographicSize = sets.orthographicSize;
            mainCam.backgroundColor = sets.backgroundColor;
        }
    }
    /************
     * 静态方法 *
     ************/
    public static void MoveTo(TVScreen target)
    {
        mover.StopAllCoroutines();
        if (target == null)
        {
            mover.StartCoroutine(moveBack());
        }
        else
        {
            mover.StartCoroutine(moveTo(target));
        }
    }
}
