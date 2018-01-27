using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 消息弹窗系统
/// </summary>
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class MessageBox : MonoBehaviour
{
    /// <summary>
    /// 设置类
    /// </summary>
    [System.Serializable]
    public struct Setting
    {
        [Range(2, 10)]
        public float 推送持续时间;
        [Range(0.5f, 2)]
        public float 推送盒子高度;
    }
    [Header("【推送盒子】")]
    [Header("文本实例")]
    public TextMesh text;
    [Header("要显示的文本")]
    [Multiline(4)]
    public string textToShow;

    private Vector3 pos;

    private void Start()
    {
        pos = transform.position;
        transform.Translate(Vector3.up * GameSystem.settings.推送设置.推送盒子高度);
    }

    [ContextMenu("显示推送")]
    public void ShowMessage()
    {
        text.text = textToShow;
        StopAllCoroutines();
        StartCoroutine(showMessage());
    }

    private IEnumerator showMessage()
    {
        GameSystem.MoveTo(gameObject, pos, transform.rotation);
        yield return new WaitForSeconds(GameSystem.settings.推送设置.推送持续时间);
        GameSystem.MoveTo(gameObject, pos + Vector3.up * GameSystem.settings.推送设置.推送盒子高度, transform.rotation);
        yield return 0;
    }
}
