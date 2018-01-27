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
    /// 混乱度
    /// </summary>
    public static float alert = 0;
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
    public float 最大混乱值;
    public float 最大警戒值;
    public BoardMover.Setting 面板移动设置;
    [Header("推送盒子")]
    public MessageBox MessageBox;
    public MessageBox.Setting 推送设置;
    [Header("【地图】")]
    public Material Map;
    public Texture2D MapTex;
    public Texture2D NoiseTex;
    [Header("时间流逝速度")]
    public float timeSpeed = 1;

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

    [Header("Prefabs")]
    public GameObject monitorPrefab;

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
    /// <summary>
    /// 判断地图对应位置的混乱等级
    /// </summary>
    /// <param name="Pos">世界坐标</param>
    /// <returns></returns>
    public static GameSystem.ChaosLevel GetChaosLevel(Vector3 Pos)
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(Pos);
        float NoiseDis = settings.Map.GetFloat("_NoiseDis");
        float v = screenPoint.y / Screen.height + NoiseDis;
        if (v >= 1) v--;
        float ud = Screen.width - 1920.0f / 1080.0f * Screen.height;
        float u = (screenPoint.x - ud / 2) / (Screen.width - ud) + NoiseDis;
        if (u >= 1) u--;

        Color c = settings.NoiseTex.GetPixel((int)(u * 1024), (int)(v * 1024));

        float value = chaos * 2 - 1 + c.r;

        if (value > settings.Map.GetFloat("_redGate"))
        {
            return ChaosLevel.red;
        }
        else if (value > settings.Map.GetFloat("_orangeGate"))
        {
            return ChaosLevel.orange;
        }
        else if (value > settings.Map.GetFloat("_yellowGate"))
        {
            return ChaosLevel.yellow;
        }
        return ChaosLevel.green;
    }
    /// <summary>
    /// 判定鼠标位置是否在陆地上
    /// </summary>
    /// <returns></returns>
    public static bool ifOnLand()
    {
        Vector3 screenPoint = Input.mousePosition;
        int v = (int)(screenPoint.y * 1080.0f / Screen.height);
        float ud = Screen.width - 1920.0f / 1080.0f * Screen.height;
        int u = (int)((screenPoint.x - ud / 2) / (Screen.width - ud) * 1920);
        Color a = settings.MapTex.GetPixel(u, v);
        return (a.a > 0.1f);
    }
    /// <summary>
    /// 增加混乱值
    /// </summary>
    /// <param name="value"></param>
    public static void AddChaos(float value)
    {
        chaos += value / settings.最大混乱值;
    }
    /// <summary>
    /// 增加警戒值
    /// </summary>
    /// <param name="value"></param>
    public static void AddAlert(float value)
    {
        alert += value / settings.最大警戒值;
    }
    /******************
    *  系统内部实现  *
    ******************/
    private void Awake()
    {
        settings = this;
        Map.SetFloat("_NoiseDis", Random.value);
        InvokeRepeating("TimeFloat", 1, 1);
    }
    private void Update()
    {
        Map.SetFloat("_chaos", chaos);
        chaos += 0.0001f;

    }
    /// <summary>
    /// 时间流逝，每秒被调用
    /// </summary>
    private void TimeFloat()
    {
        if (alert > 0.01f)
        {
            alert -= 0.01f;
        }
    }
}
