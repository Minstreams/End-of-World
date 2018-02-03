using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 报纸系统
/// </summary>
public class PaperSystem : MonoBehaviour
{
    public SpriteRenderer paperMat;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (GameSystem.GetTopic())
            {
                case GameSystem.WeChatTopic.火灾:
                    paperMat.sprite = GameSystem.settings.详细数据.报纸数据.火灾[0];
                    break;
                case GameSystem.WeChatTopic.地震:
                    paperMat.sprite = GameSystem.settings.详细数据.报纸数据.地震[0];
                    break;
                case GameSystem.WeChatTopic.黑夜:
                    paperMat.sprite = GameSystem.settings.详细数据.报纸数据.黑夜[0];
                    break;
                case GameSystem.WeChatTopic.传染病:
                    paperMat.sprite = GameSystem.settings.详细数据.报纸数据.传染病[0];
                    break;
            }
        }
    }

}
