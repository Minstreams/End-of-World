using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 一个监视器
/// </summary>
[DisallowMultipleComponent]
public class TVScreen : MonoBehaviour
{
    [Header("【这是一个监视器】")]
    [Header("【摄像机靠近显示器的位置】")]
    /// <summary>
    /// 摄像机靠近显示器的位置
    /// </summary>
    public Transform camPoint;
    [Header("【对应的摄像机】")]
    /// <summary>
    /// 对应的摄像机
    /// </summary>
    public Camera cam;
    [HideInInspector]
    /// <summary>
    /// 对应的材质
    /// </summary>
    public Material material;
    private bool inScreen = false;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            pushIn();
        }
    }

    public void pushIn()
    {
        CameraMover.MoveTo(this);
        inScreen = true;
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(1) && inScreen)
        {
            CameraMover.MoveTo(null);
            inScreen = false;
        }
    }
}
