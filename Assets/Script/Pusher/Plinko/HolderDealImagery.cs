using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lofelt.NiceVibrations;

public class HolderDealImagery : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("index")]    public int Panel;
[UnityEngine.Serialization.FormerlySerializedAs("count")]    public int Daily;
[UnityEngine.Serialization.FormerlySerializedAs("countImage")]    public SpriteRenderer DailyParis;
    int WoldPaint;
    /// <summary>
    /// ��ײ������Ҳ�ˢ�½�ҿ�����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            //TheirCar.GetInstance().PlayEffect(TheirRear.SceneMusic.sound_drop_ball,0.1f);
            collision.gameObject.SetActive(false);
            if (Daily >= 1)
            {
                WoldVeinDeal(Daily);
                if (!PeriodScratch.Instance.GoCaneCraft)
                {
                    ThinkerPaint();
                }
            }
        }
    }

    void ThinkerPaint()
    {
        Daily = TineAnnualScratch.BuyDuctless().LeoPlinkoDealPaint(Panel);
        DailyParis.sprite = Resources.Load<Sprite>(CBuckle.WedPaint + Daily);
    }

    public void WoldVeinDeal(int c)
    {
        WoldPaint += c;
        if (WoldPaint == c)
        {
            StartCoroutine(WoldVeinDealLampUser());
        }
    }

    /// <summary>
    /// ��ʱ�ͷŶ�����
    /// </summary>
    /// <returns></returns>
    IEnumerator WoldVeinDealLampUser()
    {
        while(WoldPaint > 0)
        {
            WoldPaint--;
            WoldDeal();
            yield return new WaitForSeconds(0.1f);
        }
    }
    /// <summary>
    /// ��ʼ�����λ�ò��ͷ�
    /// </summary>
    void WoldDeal()
    {
        if (PeriodScratch.Instance.GoBulge)
        {
            return;
        }
       
        if (!PeriodScratch.Instance.GoCaneCraft)
        {
            GameObject coin = PeriodScratch.Instance.LeoAdviceBark(PusherRewardType.CoinGold);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(Random.Range(0, 10), LeoDebtorDoctor(), Random.Range(0, 10));
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-30f,30f) * 0.8f, Random.Range(180f,270f) * 0.8f, Random.Range(-50f,-80f) * 0.8f));
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            GameObject coin = PeriodScratch.Instance.LeoAdviceBark(Random.Range(0,2) == 0 ? PusherRewardType.CoinGold : PusherRewardType.CoinCash);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(LeoDebtorDoctor(), LeoDebtorDoctor(), LeoDebtorDoctor());
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-10f,10f) * 0.8f, Random.Range(300f,450f) * 0.8f, Random.Range(-30f,-40f) * 0.8f));
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
        FenMarrow();
    }
    /// <summary>
    /// �Ƿ������
    /// </summary>
    bool ManMarrow= true;
    /// <summary>
    /// ��ʼ��
    /// </summary>
    void FenMarrow()
    {
        if (ManMarrow)
        {
            ManMarrow = false;
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact);
            StartCoroutine(UpwindUpsideLampUser());
        }
        
    }
    /// <summary>
    /// �𶯽�����ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator UpwindUpsideLampUser()
    {
        yield return new WaitForSeconds(0.1f);
        ManMarrow = true;
    }
    /// <summary>
    /// ��ȡ����Ƕ�
    /// </summary>
    /// <returns></returns>
    float LeoDebtorDoctor()
    {
        return Random.Range(0, 360f);
    }


    /// <summary>
    /// feverģʽ��ˢ�±���
    /// </summary>
    public void RarerPlainMorally(int c)
    {
        Daily = c;
        DailyParis.sprite = Resources.Load<Sprite>(CBuckle.WedPaint + Daily);
    }
    /// <summary>
    /// fever����ˢ��
    /// </summary>
    /// <param name="count"></param>
    public void RarerAnyMorally()
    {
        ThinkerPaint();
    }

    // Start is called before the first frame update
    void Start()
    {
        //��ʼ����ҿ�����
        ThinkerPaint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
