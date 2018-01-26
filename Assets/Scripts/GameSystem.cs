using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 喜闻乐见的游戏系统
/// </summary>
[DisallowMultipleComponent]
public class GameSystem : MonoBehaviour
{
    /******************
     *  系统全局变量  *
     ******************/
    /// <summary>
    /// 游戏系统单例
    /// </summary>
    public static GameSystem settings;
    /// <summary>
    /// 是否暂停
    /// </summary>
    public static bool pause = false;


    /******************
     *  系统设置变量  *
     ******************/
    [Header("【游戏设置】")]
    public CameraMover.Setting 相机设置;
    [Header("推送盒子")]
    public MessageBox MessageBox;
    public MessageBox.Setting 推送设置;

    /******************
     *  系统全局方法  *
     ******************/
    public static void MoveTo(GameObject obj, Vector3 pos, Quaternion rot, float speed = 0.1f)
    {
        Mover mover = obj.GetComponent<Mover>();
        if (mover != null)
        {
            Destroy(mover);
        }
        mover = obj.AddComponent<Mover>();
        mover.targetPos = pos;
        mover.targetRot = rot;
        mover.speed = speed;
    }
    public static void ShowMessageBox(string messageToShow, string information)
    {
        settings.MessageBox.textToShow = messageToShow;
        settings.MessageBox.ShowMessage();
    }

    /******************
    *  系统内部实现  *
    ******************/
    private void Awake()
    {
        settings = this;
    }
}
