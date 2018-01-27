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
    /// <summary>
    /// 混乱度
    /// </summary>
    public static float chaos = 0;


    /******************
     *  系统设置变量  *
     ******************/
    [Header("【游戏设置】")]
    public BoardMover.Setting 板子移动设置;
    [Header("推送盒子")]
    public MessageBox MessageBox;
    public MessageBox.Setting 推送设置;
    [Header("【地图】")]
    public Material Map;

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
        Map.SetFloat("_NoiseDis", Random.value);
    }
    private void Update()
    {
        Map.SetFloat("_chaos", chaos);
    }
}
