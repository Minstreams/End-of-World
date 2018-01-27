using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这是一个监听器！
/// </summary>
[DisallowMultipleComponent]
public class DetectPhone : MonoBehaviour {
    /// <summary>
    /// 放置前状态变量
    /// </summary>
    private bool ifBeforeSettle = true;
    [Header("【监视器】")]
    public BoardMover board;

}
