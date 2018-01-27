using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosTest : MonoBehaviour {
    [Header("【混乱度测试】")]
    [Range(0, 1)]
    public float chaos;

    private void Update()
    {
        GameSystem.chaos = chaos;
    }
}
