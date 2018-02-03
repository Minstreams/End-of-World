using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 这是一个监听器！
/// </summary>
[DisallowMultipleComponent]
public class DetectPhone : MonoBehaviour
{
    /// <summary>
    /// 放置前状态变量
    /// </summary>
    private bool ifBeforeSettle = true;
    [Header("【监视器】")]
    public BoardMover board;

    private void Awake()
    {
        board.target = DetectPhoneSystem.setting.boardPos;
        StartCoroutine(beforeSettle());
    }

    private IEnumerator beforeSettle()
    {
        if (Input.GetMouseButtonUp(0) && GameSystem.ifOnLand())
        {
            ifBeforeSettle = false;
            transform.GetChild(0).gameObject.layer = 0;
            gameObject.layer = 0;
            DetectPhoneSystem.Settle();

            GameSystem.PlayAudio(GameSystem.settings.音效clip.种监视器);
            GameSystem.ShowWave(transform.position);
            GameSystem.AddAlert(GameSystem.settings.不同方式的警戒影响基数.监听);
            yield return 0;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            DetectPhoneSystem.Settle();
            Destroy(gameObject);
        }
        else
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward * 20;
            yield return 0;
            yield return beforeSettle();
        }
    }

    private void OnMouseOver()
    {
        if (!ifBeforeSettle && Input.GetMouseButtonUp(0))
        {
            DetectPhoneSystem.pushIn(this);
        }
    }
}
