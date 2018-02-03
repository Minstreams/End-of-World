using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 简单的按钮，可控制一个界面
/// </summary>
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class BottonController : MonoBehaviour
{
    [Header("【按钮】")]
    [Header("控制的screen")]
    public BoardMover board;
    public AudioClip audioClip;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0)&&GameSystem.currentStatus == GameSystem.status.地图)
        {
            GameSystem.PlayAudio(audioClip);
            board.pushIn();
        }
    }
}
