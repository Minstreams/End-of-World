using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 供系统调用的移动组件
/// </summary>
[DisallowMultipleComponent]
public class Mover : MonoBehaviour
{
    public Vector3 targetPos;
    public Quaternion targetRot;
    public float speed;

    void Update()
    {
        Vector3 delta = targetPos - transform.position;
        if (delta.sqrMagnitude < 0.0001f)
        {
            transform.position = targetPos;
            transform.rotation = targetRot;
            Destroy(this);
            return;
        }
        else
        {
            transform.position += (speed * delta);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, speed);
        }
    }
}
