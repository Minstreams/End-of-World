using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosTest : MonoBehaviour
{
    [Header("【混乱度测试】")]
    [Range(0, 1)]
    public float chaos;
    [Range(0, 1)]
    public float alert;

    private void Update()
    {
        GameSystem.chaos = chaos;
        GameSystem.alert = alert;

    }
}
