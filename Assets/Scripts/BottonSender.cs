using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这是一个按钮，用来发送消息进行选择
/// </summary>
[AddComponentMenu("MyAsset/BottonSender")]
public class BottonSender : MonoBehaviour
{
    public Sprite Up;
    public Sprite Down;
    public bool active = true;
    [Range(0, 4)]
    public int index;
    [HideInInspector]
    public Reciever reciever;
    public AudioClip audioClip;
    public string message;
    public float messageDelay;
    public bool showWaves = false;

    [HideInInspector]
    public SpriteRenderer sr;
    private bool isDown = false;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseOver()
    {
        if (!active) return;
        if (!isDown && Input.GetMouseButton(0))
        {
            sr.sprite = Down;
            isDown = true;
            GameSystem.PlayAudio(audioClip);
            GameSystem.ShowMessageBox(message, messageDelay, showWaves);
        }
        else if (isDown && Input.GetMouseButtonUp(0))
        {
            sr.sprite = Up;
            isDown = false;
            if (reciever != null)
                if (reciever.Receive != null)
                    reciever.Receive(index);
        }
    }

    private void OnMouseExit()
    {
        if (!active) return;
        if (isDown)
        {
            sr.sprite = Up;
            isDown = false;
        }
    }

    public void SetActive(bool b)
    {
        active = b;
    }
}
