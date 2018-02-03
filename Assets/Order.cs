using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public GameObject 微博;
    public GameObject 微信;
    public GameObject 流言;
    public GameObject 乱象;
    public GameObject 报纸;
    public GameObject 电视;
    public GameObject 监听;
    public GameObject 监控;

    public GameObject logo0;
    public GameObject logo1;
    public GameObject logo2;

    private void Start()
    {
        StartCoroutine(order00());
    }

    private IEnumerator order00()
    {
        while (!Input.GetMouseButtonDown(0))
        {
            yield return 0;
        }
        yield return 0;
        logo1.SetActive(true);
        logo0.SetActive(false);
        GameSystem.PlayAudio(GameSystem.settings.音效clip.种监视器);
        while (!Input.GetMouseButtonDown(0))
        {
            yield return 0;
        }
        yield return 0;
        logo1.SetActive(false);
        logo2.SetActive(true);
        GameSystem.PlayAudio(GameSystem.settings.音效clip.种监视器);

        while (!Input.GetMouseButtonDown(0))
        {
            yield return 0;
        }
        yield return 0;
        GameSystem.PlayAudio(GameSystem.settings.音效clip.种监视器);
        logo2.SetActive(false);
        yield return new WaitForSeconds(2);
        监听.SetActive(true);

        while (GameSystem.alert < 2.0f / GameSystem.settings.最大警戒值)
        {
            GameSystem.ShowMessageBox("请放置监听器！");
            yield return new WaitForSeconds(8);
        }

        监控.SetActive(true);

        yield return new WaitForSeconds(5);
        微博.SetActive(true);
        StartCoroutine(order01());

        while (GameSystem.currentStatus != GameSystem.status.微博)
        {
            yield return 0;
        }
        微信.SetActive(true);

        while (GameSystem.chaos < 30.0f / GameSystem.settings.最大混乱值)
        {
            yield return 0;
        }
        GameSystem.ShowMessageBox("地区关注度上升到" + GameSystem.chaos * GameSystem.settings.最大混乱值);
        流言.SetActive(true);

        while (GameSystem.chaos < 40.0f / GameSystem.settings.最大混乱值)
        {
            yield return 0;
        }
        GameSystem.ShowMessageBox("地区关注度上升到" + GameSystem.chaos * GameSystem.settings.最大混乱值);
        乱象.SetActive(true);

        while (GameSystem.chaos < 50.0f / GameSystem.settings.最大混乱值)
        {
            yield return 0;
        }
        GameSystem.ShowMessageBox("地区关注度上升到" + GameSystem.chaos * GameSystem.settings.最大混乱值);
        报纸.SetActive(true);

        while (GameSystem.chaos < 55.0f / GameSystem.settings.最大混乱值)
        {
            yield return 0;
        }
        GameSystem.ShowMessageBox("地区关注度上升到" + GameSystem.chaos * GameSystem.settings.最大混乱值);
        电视.SetActive(true);

        while (GameSystem.chaos < 1)
        {
            yield return 0;
        }
        while (true)
        {
            GameSystem.ShowMessageBox("地区关注度已达100%，人们已经成功相信了世界末日的到来！");
            yield return new WaitForSeconds(10);
        }
    }

    private IEnumerator order01()
    {
        while (GameSystem.alert < 1)
        {
            yield return 0;
        }
        GameSystem.ShowMessageBox("街上警察经常巡逻，已经没办法制造人祸了");
        GameSystem.PlayAudio(GameSystem.settings.音效clip.gg);
        乱象.SetActive(false);
        while (GameSystem.alert > 0.8f)
        {
            yield return 0;

        }
        while (GameSystem.alert < 1)
        {
            yield return 0;
        }
        GameSystem.PlayAudio(GameSystem.settings.音效clip.gg);
        GameSystem.ShowMessageBox("最近造谣是要入刑的！！");
        流言.SetActive(false);
        while (GameSystem.alert > 0.8f)
        {
            yield return 0;

        }
        while (GameSystem.alert < 1)
        {
            yield return 0;
        }
        GameSystem.PlayAudio(GameSystem.settings.音效clip.gg);
        GameSystem.ShowMessageBox("文章被举报……公众号被冻结……");
        微信.SetActive(false);
        while (GameSystem.alert > 0.8f)
        {
            yield return 0;

        }
        while (GameSystem.alert < 1)
        {
            yield return 0;
        }
        GameSystem.PlayAudio(GameSystem.settings.音效clip.gg);
        GameSystem.ShowMessageBox("微博居然也开始整治谣言了。");
        微博.SetActive(false);
        while (GameSystem.alert > 0.8f)
        {
            yield return 0;

        }
        GameSystem.ShowMessageBox("你死了。重来吧");
    }
}
