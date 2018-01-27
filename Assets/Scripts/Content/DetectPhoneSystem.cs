using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 窃听器系统
/// </summary>
public class DetectPhoneSystem : MonoBehaviour {
    [Header("【窃听系统】")]
    [Header("screen面板")]
    public Transform boardPos;
    [Header("监控面板")]
    public Material DetectBoard;

    public static DetectPhoneSystem setting;
    private static bool isPickingUp = false;
    public static GameSystem.ChaosLevel level;
    public static int sceneIndex;
    private void Awake()
    {
        setting = this;
    }
}
