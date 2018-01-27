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
    /// <summary>
    /// 混乱等级
    /// </summary>
    public enum ChaosLevel
    {
        green, yellow, orange, red
    }
    /// <summary>
    /// 微博话题种类
    /// </summary>
    public enum WeChatTopic
    {
        火灾, 地震, 黑夜, 传染病
    }


    /******************
     *  系统设置变量  *
     ******************/
    [Header("【游戏设置】")]
    public BoardMover.Setting 面板移动设置;
    [Header("推送盒子")]
    public MessageBox MessageBox;
    public MessageBox.Setting 推送设置;
    [Header("【地图】")]
    public Material Map;

    [System.Serializable]
    public struct Dialog
    {
        [Multiline(2)]
        public string[] 具体对话;
    }
    [System.Serializable]
    public struct MonitorData
    {
        public MonitorTexData[] 图片数据;
        public Dialog[] 绿色对话;
        public Dialog[] 黄色对话;
        public Dialog[] 橙色对话;
        public Dialog[] 红色对话;
    }
    [System.Serializable]
    public struct MonitorTexData
    {
        public Texture2D 图片1;
    }
    [System.Serializable]
    public struct DetectPhoneData
    {
        public Dialog[] 绿色对话;
        public Dialog[] 黄色对话;
        public Dialog[] 橙色对话;
        public Dialog[] 红色对话;
    }
    [System.Serializable]
    public struct WeiBoTopicData
    {
        [Multiline(5)]
        public string[] 预测;
        [Multiline(5)]
        public string[] 煽动;
    }
    [System.Serializable]
    public struct WeiBoData
    {
        public WeiBoTopicData 火灾;
        public WeiBoTopicData 地震;
        public WeiBoTopicData 黑夜;
        public WeiBoTopicData 传染病;
    }
    [System.Serializable]
    public struct WeChatSingleData
    {
        [Multiline(4)]
        public string[] 火灾;
        [Multiline(4)]
        public string[] 地震;
        [Multiline(4)]
        public string[] 黑夜;
        [Multiline(4)]
        public string[] 传染病;
    }
    [System.Serializable]
    public struct WeChatData
    {
        public WeChatSingleData 发消息;
        public WeChatSingleData 朋友圈;
        [Multiline(4)]
        public string[] 朋友圈预制;
    }
    [System.Serializable]
    public struct PaperData
    {
        public Texture2D[] 火灾;
        public Texture2D[] 地震;
        public Texture2D[] 黑夜;
        public Texture2D[] 传染病;
    }
    [System.Serializable]
    public struct NewsSingleData
    {
        Texture2D 图片;
        [Multiline(2)]
        public string 标题;
    }
    [System.Serializable]
    public struct NewsData
    {
        public NewsSingleData[] 火灾;
        public NewsSingleData[] 地震;
        public NewsSingleData[] 黑夜;
        public NewsSingleData[] 传染病;
    }
    [System.Serializable]
    public struct AllData
    {
        public MonitorData 监视器数据;
        public DetectPhoneData 监听器数据;
        public WeiBoData 微博数据;
        public WeChatData 微信数据;
        public PaperData 报纸数据;
        public NewsData 新闻数据;
    }
    public AllData 详细数据;

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
