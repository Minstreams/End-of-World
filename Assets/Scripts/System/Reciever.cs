using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用来接收按钮的消息
/// </summary>
public class Reciever : MonoBehaviour {
    public delegate void SwitchByValue(int value);
    public SwitchByValue Receive;

    /// <summary>
    /// 关联的按钮
    /// </summary>
    public BottonSender[] senders;

    private void Awake()
    {
        foreach(BottonSender bs in senders)
        {
            bs.reciever = this;
        }
    }
}
