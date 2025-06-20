// Project: Pusher
// FileName: ThankCapePassageway.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:54
// Description:

using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ThankCapePassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("bgGold")]    public GameObject NoStir;
[UnityEngine.Serialization.FormerlySerializedAs("bgSilver")]    public GameObject NoIgnore;
[UnityEngine.Serialization.FormerlySerializedAs("bgTop")]    public GameObject NoCar;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject JoltRay;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]    public GameObject SparRay;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject SprawlRay;
[UnityEngine.Serialization.FormerlySerializedAs("overImg")]    public GameObject PipeRay;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Open")]    public GameObject No_Gibe;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text BurrowAfar;
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]
    public LuckyObjType BurrowRear;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double BurrowSod;



    public void ShaftCry()
    {
        ShaftRay();
        //bgTop.gameObject.SetActive(true);
    }


    public void NoseAdviceCryTine(LuckyObjData luckyObjData)
    {
        BG.SetActive(true);
        BurrowRear = luckyObjData.LuckyObjType;
        BurrowSod = luckyObjData.RewardNum;
        ShaftRay();
        BurrowAfar.text = BurrowSod+"";

        switch (BurrowRear)
        {
            case LuckyObjType.Cash:
                JoltRay.gameObject.SetActive(true);
                break;
            case LuckyObjType.Gold:
                SparRay.gameObject.SetActive(true);
                NoIgnore.gameObject.SetActive(true);
                break;
            default:
                SprawlRay.gameObject.SetActive(true);
                NoIgnore.gameObject.SetActive(true);
                break;
        }

    }

    public void NoseRetireCryTine()
    {
        BG.SetActive(true);
        ShaftRay();
        PipeRay.gameObject.SetActive(true);
    }

    private void ShaftRay()
    {
        NoCar.gameObject.SetActive(false);
        JoltRay.gameObject.SetActive(false);
        SprawlRay.gameObject.SetActive(false);
        SparRay.gameObject.SetActive(false);
        NoIgnore.gameObject.SetActive(false);
        PipeRay.gameObject.SetActive(false);
        NoStir.gameObject.SetActive(true);
        
    }


    private void OnMouseOver()
    {
        if (NoCar.activeInHierarchy != true||ThankCapePress.Instance.GoClue) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            //bgTop.gameObject.SetActive(false);
            TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.Sound_PopShow);
            ThankCapePress.Instance.NorSparseRent(gameObject);
        }
    }

    public void CradPrimitive(GameObject Card, GameObject CardBack, GameObject CardFront,System.Action start, System.Action finish) 
    {
        Card.transform.DOScale(1.3f, 0.3f);
        Card.transform.DORotate(new Vector3(0, 90, 0), 0.3f).OnComplete(() =>
        {
            start();
            CardBack.SetActive(false);
            CardFront.SetActive(true);
            Card.transform.DOScale(1, 0.3f);
            Card.transform.DORotate(new Vector3(0, 0, 0), 0.3f).OnComplete(()=>
            {
                finish();
            });
        });
    }
}