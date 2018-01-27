using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这是一个板子
/// </summary>
[DisallowMultipleComponent]
public class BoardMover : MonoBehaviour
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
    //默认设置
    private Vector3 origPosition;
    private Quaternion origRotation;
    private Vector3 origScale;
    private float sqrtDistance;
    public Transform target;
    private bool inScreen = false;
    private Material mat;

    /************
     * 内部方法 *
     ************/
    private void Start()
    {
        
        mat = GetComponent<Renderer>().material;
    }

    //移动
    private IEnumerator moveTo()
    {

        yield return moveToPoint(false);
        yield return 0;
    }
    //返回
    private IEnumerator moveBack()
    {
        yield return moveToPoint(true);
        yield return 0;
    }
    private IEnumerator moveToPoint(bool ifBack = false)
    {
        Vector3 delta = (ifBack ? origPosition : target.position) - transform.position;
        float deltaSqrtDis = delta.sqrMagnitude;

        Vector3 deltaScale = (ifBack ? origScale : target.localScale) - transform.localScale;
        if (deltaSqrtDis < 0.001f && deltaScale.sqrMagnitude < 0.001f)
        {
            if (ifBack)
            {
                transform.position = origPosition;
                transform.rotation = origRotation;
                transform.localScale = origScale;
                mat.SetFloat("_progress", 0);
            }
            else
            {
                transform.position = target.position;
                transform.rotation = target.rotation;
                transform.localScale = target.localScale;
                mat.SetFloat("_progress", 1);
            }
            yield return 0;
        }
        else
        {
            float progress = deltaSqrtDis / sqrtDistance;
            if (!ifBack)
            {
                progress = 1 - progress;
            }
            transform.Translate(delta * GameSystem.settings.面板移动设置.移动缓动值);
            transform.localScale += deltaScale * GameSystem.settings.面板移动设置.移动缓动值;
            transform.rotation = Quaternion.Slerp(transform.rotation, ifBack ? origRotation : target.rotation, GameSystem.settings.面板移动设置.旋转缓动值);
            mat.SetFloat("_progress", progress);
            yield return 0;
            yield return moveToPoint(ifBack);
        }
    }

    /************
     * 静态方法 *
     ************/
    [ContextMenu("PushIn")]
    public void pushIn()
    {
        if (!inScreen)
        {
            origPosition = transform.position;
            origRotation = transform.rotation;
            origScale = transform.localScale;
            sqrtDistance = (origPosition - target.position).sqrMagnitude;
            StopAllCoroutines();
            inScreen = true;
            StartCoroutine(moveTo());
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(1) && inScreen)
        {
            StopAllCoroutines();
            StartCoroutine(moveBack());
            inScreen = false;
        }
    }
}
