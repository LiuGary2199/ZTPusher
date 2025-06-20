// Project: HappyBingo
// FileName: WebWedPassageway.cs
// Author: AX
// CreateDate: 20221124
// CreateTime: 11:39
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebWedPassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("flyBox")]    public GameObject ToeWed;

    private int _DrugChemurgy;

    private int _ChronicUser;
[UnityEngine.Serialization.FormerlySerializedAs("isOnFlag")]
    public bool GoNoHoly;

    private Dictionary<NormalRewardType, double> BurrowToo;

    public static WebWedPassageway Instance;


    private void Awake()
    {
        Instance = this;
        _DrugChemurgy = BisHeadCar.instance.DramTine.base_config.bubble_time;
    }

    IEnumerator WedUserChemurgy()
    {
        while (GoNoHoly)
        {
            if (_ChronicUser >= _DrugChemurgy)
            {
                _ChronicUser = 0;
                WeldonWebWed();
            }

            _ChronicUser++;
            //print(_currentTime);
            yield return new WaitForSeconds(1);
        }
    }


    public void SnailHopPlainWed()
    {
        GoNoHoly = true;
        _ChronicUser = 0;
        StartCoroutine(WedUserChemurgy());
        WeldonWebWed();
    }

    public void LadyWed()
    {
        if (!gameObject.activeInHierarchy) return;
        GoNoHoly = false;
        StopCoroutine(WedUserChemurgy());
        if (transform.childCount > 0)
        {
            //transform.GetChild(0).GetComponent<WebDecode>().WebBulge();
            //transform.GetChild(0).GetComponent<Canvas>().sortingOrder = 90;
            transform.gameObject.SetActive(false);
        }
    }

    public void YouWedOakRadius()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<WebDecode>().YouOakRadius();
        }
    }

    public void YouWedOakPerfume()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<WebDecode>().YouOakPerfume();
        }
    }

    public void WitnessWed()
    {
        gameObject.SetActive(true);
        if (gameObject.activeInHierarchy)
        {
            GoNoHoly = true;
            StartCoroutine(WedUserChemurgy());
            if (transform.childCount > 0)
            {
                //transform.GetChild(0).GetComponent<WebDecode>().WebMaraca();
                //transform.GetChild(0).GetComponent<Canvas>().sortingOrder = 120;
                transform.gameObject.SetActive(true);
            }
        }
    }

    public void WeldonWebWed()
    {
        if (VacantSkin.AtTract()) return;
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_Juicy_Fix_Fox) == "new") return;
        GameObject obj = Instantiate(ToeWed, transform);
        obj.transform.SetParent(gameObject.transform);
        obj.SetActive(true);
    }

    public void AssetTine()
    {
        GoNoHoly = false;
        _ChronicUser = 0;
        if (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void BuryPronePress()
    {
        HuntScratch.Instance.DramLady();

        BurrowToo = new Dictionary<NormalRewardType, double>();
        BubbleObjData bubbleObjData = GameUtil.GetBubbleObjData();
        
        string type = bubbleObjData.BubbleObjType.ToString();
        NormalRewardType BurrowRear= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        BurrowToo.Add(BurrowRear, bubbleObjData.RewardNum);
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_ID_Go,"6");
        AutoTineScratch.YouLaunch(CBuckle.Go_Weaken_Too_Drip, "1013");
        AdvicePressScratch.Instance.BuryChoppyAdvicePress(BurrowToo);

    }
}