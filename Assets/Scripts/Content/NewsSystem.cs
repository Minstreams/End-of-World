using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 新闻系统
/// </summary>
public class NewsSystem : MonoBehaviour {
    public SpriteRenderer newsMat;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (GameSystem.GetTopic())
            {
                case GameSystem.WeChatTopic.火灾:
                    newsMat.sprite = GameSystem.settings.详细数据.新闻数据.火灾[0].图片;
                    break;
                case GameSystem.WeChatTopic.地震:
                    newsMat.sprite = GameSystem.settings.详细数据.新闻数据.地震[0].图片;
                    break;
                case GameSystem.WeChatTopic.黑夜:
                    newsMat.sprite = GameSystem.settings.详细数据.新闻数据.黑夜[0].图片;
                    break;
                case GameSystem.WeChatTopic.传染病:
                    newsMat.sprite = GameSystem.settings.详细数据.新闻数据.传染病[0].图片;
                    break;
            }
        }
    }
}
