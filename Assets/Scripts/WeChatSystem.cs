using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeChatSystem : Reciever
{
    //朋友圈
    private GameObject pos1;
    private GameObject pos2;

    public TextMesh[] Texts;

    public Transform InfoParent;

    void Start()
    {
        Receive += recieve;

    }
    private void recieve(int value)
    {
        Sprite result = null;
        switch (GameSystem.GetTopic())
        {
            case GameSystem.WeChatTopic.火灾:
                result = GameSystem.settings.详细数据.微信数据.朋友圈.火灾图[value];
                break;
            case GameSystem.WeChatTopic.地震:
                result = GameSystem.settings.详细数据.微信数据.朋友圈.地震图[value];
                break;
            case GameSystem.WeChatTopic.黑夜:
                result = GameSystem.settings.详细数据.微信数据.朋友圈.黑夜图[value];
                break;
            case GameSystem.WeChatTopic.传染病:
                result = GameSystem.settings.详细数据.微信数据.朋友圈.传染病图[value];
                break;
            case GameSystem.WeChatTopic.None:
                return;
        }
        newInfo(result);
        SetSenders(false);
        Invoke("Reborn", GameSystem.settings.wechatCD2);
    }
    private int 热度 = 0;
    public void newInfo(Sprite sprite, bool auto = false)
    {
        if (!auto)
        {
            GameSystem.AddAlert(GameSystem.settings.不同方式的警戒影响基数.微信朋友圈);
            GameSystem.AddChaos(GameSystem.settings.不同方式的混乱影响基数.微信朋友圈, GameSystem.GetTopic());
            热度 += Random.Range(20, 40);
            GameSystem.ShowMessageBox("微信朋友圈浏览量" + 热度 + "人次", Random.Range(3.0f, 6.0f));
        }
        if (pos2 != null) Destroy(pos2);
        pos2 = pos1;
        pos1 = Instantiate(GameSystem.settings.wechatPrefab, InfoParent);
        pos1.GetComponent<SpriteRenderer>().sprite = sprite;
        if (pos2 != null) GameSystem.MoveTo(pos2, pos2.transform.position - pos2.transform.up * 1.5f, pos2.transform.rotation);
    }


    public void SetSenders(bool active)
    {
        foreach (BottonSender bs in senders)
        {
            bs.SetActive(active);
            bs.sr.sprite = bs.Up;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (GameSystem.GetTopic())
            {
                case GameSystem.WeChatTopic.火灾:
                    Texts[0].text = GameSystem.settings.详细数据.微信数据.朋友圈.火灾[0];
                    Texts[1].text = GameSystem.settings.详细数据.微信数据.朋友圈.火灾[1];
                    break;
                case GameSystem.WeChatTopic.地震:
                    Texts[0].text = GameSystem.settings.详细数据.微信数据.朋友圈.地震[0];
                    Texts[1].text = GameSystem.settings.详细数据.微信数据.朋友圈.地震[1];
                    break;
                case GameSystem.WeChatTopic.黑夜:
                    Texts[0].text = GameSystem.settings.详细数据.微信数据.朋友圈.黑夜[0];
                    Texts[1].text = GameSystem.settings.详细数据.微信数据.朋友圈.黑夜[1];
                    break;
                case GameSystem.WeChatTopic.传染病:
                    Texts[0].text = GameSystem.settings.详细数据.微信数据.朋友圈.传染病[0];
                    Texts[1].text = GameSystem.settings.详细数据.微信数据.朋友圈.传染病[1];
                    break;
            }
        }
    }
    private void Reborn()
    {
        SetSenders(true);
        print("Reborn!");
    }
}
