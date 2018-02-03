using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveXY : MonoBehaviour
{
    private float theta;
    private Vector3 pos;
    public float speed;
    public float height;
    public float width;

    private void Awake()
    {
        pos = transform.position;
    }
    void Update()
    {
        theta += speed / 360;
        transform.position = pos + new Vector3(width * Mathf.Cos(theta), height * Mathf.Sin(theta), 0);
    }
}
