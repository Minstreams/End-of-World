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
        火灾, 地震, 黑夜, 传染病, None
    }
    public enum status
    {
        地图, 监视器, 监听器, 微博, 微信, 流言, 人祸, 电视, 报纸
    }
    public static status currentStatus = status.地图;
    /******************
     *  系统设置变量  *
     ******************/
    [Header("【游戏设置】")]
    public float 最大混乱值 = 100;
    public float 最大警戒值 = 100;
    public float 相似系数 = 1.25f;
    [System.Serializable]
    public struct chaosRate
    {
        public float 微博;
        public float 微信消息;
        public float 微信朋友圈;
        public float 语言;
        public float 雇人搞事情;
        public float 报纸;
        public float 电视;
    }
    public chaosRate 不同方式的混乱影响基数;
    [System.Serializable]
    public struct alertRate
    {
        public float 微博;
        public float 微信消息;
        public float 微信朋友圈;
        public float 语言;
        public float 雇人搞事情;
        public float 报纸;
        public float 电视;
        public float 监视;
        public float 监听;
    }
    public alertRate 不同方式的警戒影响基数;

    [System.Serializable]
    public struct audios
    {
        public AudioClip 种监视器;
        public AudioClip 推送;
        public AudioClip gg;
    }
    public audios 音效clip;
    public BoardMover.Setting 面板移动设置;
    [Header("推送盒子")]
    public MessageBox MessageBox;
    public MessageBox.Setting 推送设置;
    public float 对话间隔时间;
    [Header("【地图】")]
    public Material Map;
    public Texture2D MapTex;
    public Texture2D NoiseTex;
    [Header("警诫条")]
    public Material AlertBar;
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
        public Sprite[] 预测;
        public Sprite[] 煽动;
    }
    [System.Serializable]
    public struct WeiBoData
    {
        public WeiBoTopicData 火灾;
        public WeiBoTopicData 地震;
        public WeiBoTopicData 黑夜;
        public WeiBoTopicData 传染病;
        public Sprite[] NPC;
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

        public Sprite[] 火灾图;
        public Sprite[] 地震图;
        public Sprite[] 黑夜图;
        public Sprite[] 传染病图;
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
        public Sprite[] 火灾;
        public Sprite[] 地震;
        public Sprite[] 黑夜;
        public Sprite[] 传染病;
    }
    [System.Serializable]
    public struct NewsSingleData
    {
        public Sprite 图片;
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
    public ParticleSystem waves;
    public ParticleSystem wave;
    public GameObject monitorPrefab;
    public GameObject detectPhonePrefab;
    public GameObject weiboInfoPrefab;
    public GameObject wechatPrefab;

    [Header("CD")]
    public float weiboCD;
    public float wechatCD2;
    public float 人祸CD;
    public float 流言CD;

    /******************
     *  系统全局方法  *
     ******************/
    /// <summary>
    /// 移动任意物体
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="pos"></param>
    /// <param name="rot"></param>
    /// <param name="speed"></param>
    public static void MoveTo(GameObject obj, Vector3 pos, Quaternion rot, float speed = 0.1f)
    {
        if (obj == null) return;
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
    /// <summary>
    /// 显示推送
    /// </summary>
    /// <param name="messageToShow"></param>
    /// <param name="information"></param>
    public static void ShowMessageBox(string messageToShow, float seconds = 0, bool showWaves = false)
    {
        settings.StartCoroutine(ShowMessage(messageToShow, seconds, showWaves));
    }
    private static IEnumerator ShowMessage(string messageToShow, float seconds, bool showWaves)
    {
        yield return new WaitForSeconds(seconds);
        if (showWaves) ShowWaves();
        settings.MessageBox.textToShow = messageToShow;
        settings.MessageBox.ShowMessage();
        yield return 0;
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
    public static void AddChaos(float value, WeChatTopic topic)
    {
        if (lastTopic == topic)
        {
            chaosBonus *= settings.相似系数;
        }
        else
        {
            chaosBonus = 1;
            lastTopic = topic;
        }
        chaosT += value * chaosBonus / settings.最大混乱值;
    }
    /// <summary>
    /// 增加警戒值
    /// </summary>
    /// <param name="value"></param>
    public static void AddAlert(float value)
    {
        alertT += value / settings.最大警戒值;
    }
    /// <summary>
    /// 获取当前主题
    /// </summary>
    public static WeChatTopic GetTopic()
    {
        return lastTopic;
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="ac"></param>
    public static void PlayAudio(AudioClip ac)
    {
        if (ac == null) return;
        settings.StartCoroutine(playAudio(ac));
    }
    public static void ChangeBGM(AudioClip ac)
    {
        if (ac == null)
        {
            bgmPlus.Stop();
            bgm.volume = bgmVo;
        }
        else
        {
            bgm.volume = bgmVo * 0.2f;
            bgmPlus.clip = ac;
            bgmPlus.Play();
        }
    }
    public static void ShowWaves()
    {
        settings.waves.Play();
    }
    public static void ShowWave(Vector3 pos)
    {
        pos.x *= -1;
        pos.y *= -1;
        settings.wave.transform.position = pos;
        settings.wave.Play();
    }
    /******************
    *  系统内部实现  *
    ******************/
    private static float chaosT = 0;
    private static float alertT = 0;
    private static float chaosBonus = 1;
    private static WeChatTopic lastTopic = WeChatTopic.None;
    private static AudioSource bgm;
    private static AudioSource bgmPlus;
    private static float bgmVo;

    private void Awake()
    {
        settings = this;
        bgm = GetComponent<AudioSource>();
        bgmVo = bgm.volume;
        bgmPlus = gameObject.AddComponent<AudioSource>();
        bgmPlus.playOnAwake = false;
        bgmPlus.loop = true;
        Map.SetFloat("_NoiseDis", Random.value);
        InvokeRepeating("TimeFloat", 1, 1);
    }
    private void Update()
    {
        Map.SetFloat("_chaos", chaos);
        AlertBar.SetFloat("_alert", alert);

        chaos += (chaosT - chaos) * 0.001f;
        alert += (alertT - alert) * 0.01f;

    }
    private static IEnumerator playAudio(AudioClip ac)
    {
        AudioSource audioSource = settings.gameObject.AddComponent<AudioSource>();
        audioSource.clip = ac;
        audioSource.Play();
        yield return new WaitForSeconds(ac.length + 2);
        Destroy(audioSource);
        yield return 0;
    }

    /// <summary>
    /// 时间流逝，每秒被调用
    /// </summary>
    private void TimeFloat()
    {
        if (alertT > 0.01f)
        {
            alertT -= 0.01f;
        }
    }
}
