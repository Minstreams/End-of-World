using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeiboSystem : Reciever
{
    private GameObject pos1;
    private GameObject pos2;
    private GameObject pos3;

    private bool firstTime = true;
    public TextMesh[] Texts;

    private GameSystem.WeChatTopic currentTopic;
    public Transform InfoParent;
    void Start()
    {
        Receive += recieve;
        Texts[0].text = "火灾";
        Texts[1].text = "地震";
        Texts[2].text = "黑夜";
    }

    private int tempValue;
    private void recieve(int value)
    {
        if (value < 3)
        {
            senders[tempValue].enabled = true;
            senders[tempValue].sr.sprite = senders[value].Up;
            tempValue = value;
            senders[tempValue].sr.sprite = senders[value].Down;
            senders[tempValue].enabled = false;
        }
        else
        {
            Sprite result = null;
            if (firstTime)
            {
                switch (tempValue)
                {
                    case 0:
                        currentTopic = GameSystem.WeChatTopic.火灾;
                        result = GameSystem.settings.详细数据.微博数据.火灾.预测[MyRandom.Range(0, 3)];
                        break;
                    case 1:
                        currentTopic = GameSystem.WeChatTopic.地震;
                        result = GameSystem.settings.详细数据.微博数据.地震.预测[MyRandom.Range(0, 3)];
                        break;
                    case 2:
                        currentTopic = GameSystem.WeChatTopic.黑夜;
                        result = GameSystem.settings.详细数据.微博数据.黑夜.预测[MyRandom.Range(0, 3)];
                        break;
                }
                GameSystem.ShowMessageBox("微博转发量 " + Random.Range(30, 50) + "条, 评论数目 " + Random.Range(60, 80) + "条", Random.Range(9.0f, 16.0f));
                GameSystem.ShowMessageBox("微博话题#世界末日#热度已达 " + Random.Range(900, 1200), Random.Range(30.0f, 40.0f));


                firstTime = false;
                Texts[0].text = "继续预测";
                Texts[1].text = "煽动舆情";
                Texts[2].text = "开辟新话题";
            }
            else
            {
                switch (tempValue)
                {
                    case 0:
                        switch (currentTopic)
                        {
                            case GameSystem.WeChatTopic.火灾:
                                result = GameSystem.settings.详细数据.微博数据.火灾.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.地震:
                                result = GameSystem.settings.详细数据.微博数据.地震.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.黑夜:
                                result = GameSystem.settings.详细数据.微博数据.黑夜.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.传染病:
                                result = GameSystem.settings.详细数据.微博数据.传染病.预测[MyRandom.Range(0, 3)];
                                break;
                        }
                        break;
                    case 1:
                        switch (currentTopic)
                        {
                            case GameSystem.WeChatTopic.火灾:
                                result = GameSystem.settings.详细数据.微博数据.火灾.煽动[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.地震:
                                result = GameSystem.settings.详细数据.微博数据.地震.煽动[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.黑夜:
                                result = GameSystem.settings.详细数据.微博数据.黑夜.煽动[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.传染病:
                                result = GameSystem.settings.详细数据.微博数据.传染病.煽动[MyRandom.Range(0, 3)];
                                break;
                        }
                        break;
                    case 2:
                        currentTopic += MyRandom.Range(0, 3) + 1;
                        if (currentTopic >= GameSystem.WeChatTopic.None) currentTopic -= 4;
                        switch (currentTopic)
                        {
                            case GameSystem.WeChatTopic.火灾:
                                result = GameSystem.settings.详细数据.微博数据.火灾.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.地震:
                                result = GameSystem.settings.详细数据.微博数据.地震.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.黑夜:
                                result = GameSystem.settings.详细数据.微博数据.黑夜.预测[MyRandom.Range(0, 3)];
                                break;
                            case GameSystem.WeChatTopic.传染病:
                                result = GameSystem.settings.详细数据.微博数据.传染病.预测[MyRandom.Range(0, 3)];
                                break;
                        }
                        break;
                }
            }
            newInfo(result);
            SetSenders(false);
            Invoke("Reborn", GameSystem.settings.weiboCD);
        }
    }

    public void newInfo(Sprite sprite)
    {
        GameSystem.AddAlert(GameSystem.settings.不同方式的警戒影响基数.微博);
        GameSystem.AddChaos(GameSystem.settings.不同方式的混乱影响基数.微博, currentTopic);
        if (pos3 != null) Destroy(pos3);
        pos3 = pos2;
        pos2 = pos1;
        pos1 = Instantiate(GameSystem.settings.weiboInfoPrefab, InfoParent);
        pos1.GetComponent<SpriteRenderer>().sprite = sprite;
        if (pos3 != null) GameSystem.MoveTo(pos3, pos3.transform.position - pos3.transform.up * 1.6f, pos3.transform.rotation);
        if (pos2 != null) GameSystem.MoveTo(pos2, pos2.transform.position - pos2.transform.up * 1.6f, pos2.transform.rotation);
        GameSystem.MoveTo(pos1, pos1.transform.position - pos1.transform.up * 1.6f, pos1.transform.rotation);
        StartCoroutine(timetest());
    }

    private IEnumerator timetest()
    {
        yield return new WaitForSeconds(1);
        if (GameSystem.currentStatus != GameSystem.status.微博)
        {
            GameSystem.ShowMessageBox("这个bug被你发现了~");
        }
        yield return 0;
    }

    public void SetSenders(bool active)
    {
        foreach (BottonSender bs in senders)
        {
            bs.SetActive(active);
            bs.sr.sprite = bs.Up;
        }
        if (!active)
        {
            senders[3].sr.sprite = senders[3].Down;
        }
    }

    private void Reborn()
    {
        SetSenders(true);
        print("Reborn!");
    }

    private IEnumerator firstWeiboZhuanfa()
    {
        yield return new WaitForSeconds(Random.Range(9.0f, 16.0f));
    }
}
