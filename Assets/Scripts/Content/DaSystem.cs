using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaSystem : Reciever
{

    public TextMesh text;

    public GameObject textParent;
    public GameObject bottonParent;
    void Start()
    {
        Receive += recieve;
    }
    private void recieve(int value)
    {
        switch (value)
        {
            case 0:
                text.text = "呱闻天下：呱年蛙月蛤日，\n我市市中心仓库发生火灾，\n起火原因暂未分明。";
                break;
            case 1:
                text.text = "呱呱部提醒：近期出现邪\n教组织散播虚假消息，\n严重扰乱社会秩序，本部\n必将严厉打击其行为。";
                break;
            case 2:
                text.text = "呱浪头条：咣咣市市中心多\n家店铺遭打砸，肇事者至\n今未归案。";
                break;
        }
        SetSenders(false);
        Invoke("Reborn", GameSystem.settings.人祸CD);
    }
    public void SetSenders(bool active)
    {
        if (active)
        {
            textParent.SetActive(false);
            bottonParent.SetActive(true);
        }
        else
        {
            textParent.SetActive(true);
            bottonParent.SetActive(false);
        }
    }
    private void Reborn()
    {
        SetSenders(true);
    }
}
