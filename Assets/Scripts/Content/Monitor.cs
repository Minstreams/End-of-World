using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这是一个监视器！
/// </summary>
[DisallowMultipleComponent]
public class Monitor : MonoBehaviour
{
    /// <summary>
    /// 放置前状态变量
    /// </summary>
    private bool ifBeforeSettle = true;
    [Header("【监视器】")]
    public BoardMover board;
    /// <summary>
    /// 场景编号
    /// </summary>
    public int index = -1;


    private void Awake()
    {
        board.target = MonitorSystem.setting.boardPos;
        StartCoroutine(beforeSettle());
    }

    private IEnumerator beforeSettle()
    {
        if (Input.GetMouseButtonUp(0) && GameSystem.ifOnLand())
        {
            ifBeforeSettle = false;
            transform.GetChild(0).gameObject.layer = 0;
            gameObject.layer = 0;
            MonitorSystem.Settle();
            yield return 0;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            MonitorSystem.Settle();
            Destroy(gameObject);
        }
        else
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward * 12;
            yield return 0;
            yield return beforeSettle();
        }
    }

    private void OnMouseOver()
    {
        if (!ifBeforeSettle && Input.GetMouseButtonUp(0))
        {
            MonitorSystem.pushIn(this);
        }
    }
}
