using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 干脆挂在按钮上好了
/// </summary>
public class MonitorSystem : MonoBehaviour
{
    [Header("【监控系统】")]
    [Header("screen面板")]
    public Transform boardPos;
    [Header("监控面板")]
    public Material MonitorBoard;
    public TextMesh text;


    public static MonitorSystem setting;
    private static bool isPickingUp = false;
    public static GameSystem.ChaosLevel level;
    public static int sceneIndex;
    private void Awake()
    {
        setting = this;
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && !isPickingUp)
        {
            PickUp();
        }
    }
    public static void PickUp()
    {
        isPickingUp = true;
        Instantiate(GameSystem.settings.monitorPrefab);
    }
    /// <summary>
    /// 由monitor在放置完成时调用，在此写逻辑
    /// </summary>
    public static void Settle()
    {
        isPickingUp = false;
    }

    public static void pushIn(Monitor monitor)
    {
        level = GameSystem.GetChaosLevel(monitor.transform.position);
        print(level);
        if (monitor.index < 0)
        {
            monitor.index = MyRandom.Range(0, GameSystem.settings.详细数据.监视器数据.图片数据.Length);
        }
        sceneIndex = monitor.index;
        setting.MonitorBoard.SetTexture("_MainTex", GameSystem.settings.详细数据.监视器数据.图片数据[sceneIndex].图片1);
        monitor.board.pushIn();
        setting.StartCoroutine(setting.Dialog());
    }

    /// <summary>
    /// 原地爆炸
    /// </summary>
    public static void Broke()
    {
        //TODO: 改变外观
        setting.enabled = false;
    }

    private IEnumerator Dialog()
    {
        string[] dialog = null;
        switch (level)
        {
            case GameSystem.ChaosLevel.green:
                dialog = GameSystem.settings.详细数据.监视器数据.绿色对话[MyRandom.Range(0, GameSystem.settings.详细数据.监听器数据.绿色对话.Length)].具体对话;
                break;
            case GameSystem.ChaosLevel.yellow:
                dialog = GameSystem.settings.详细数据.监视器数据.黄色对话[MyRandom.Range(0, GameSystem.settings.详细数据.监听器数据.黄色对话.Length)].具体对话;
                break;
            case GameSystem.ChaosLevel.orange:
                dialog = GameSystem.settings.详细数据.监视器数据.橙色对话[MyRandom.Range(0, GameSystem.settings.详细数据.监听器数据.橙色对话.Length)].具体对话;
                break;
            case GameSystem.ChaosLevel.red:
                dialog = GameSystem.settings.详细数据.监视器数据.红色对话[MyRandom.Range(0, GameSystem.settings.详细数据.监听器数据.红色对话.Length)].具体对话;
                break;
        }
        StartCoroutine(statusDetect());
        yield return Dialog(dialog, 0);
    }
    private IEnumerator Dialog(string[] log, int ptr)
    {
        text.text = log[ptr];
        yield return new WaitForSeconds(GameSystem.settings.对话间隔时间);
        ptr++;
        if (ptr >= log.Length)
        {
            ptr -= log.Length;
        }
        yield return Dialog(log, ptr);
        yield return 0;
    }
    private IEnumerator statusDetect()
    {
        if (GameSystem.currentStatus == GameSystem.status.地图)
        {
            StopAllCoroutines();
        }
        yield return 0;
        yield return statusDetect();
    }
}
