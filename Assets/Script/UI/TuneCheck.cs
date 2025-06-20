using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuneCheck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject NoseCheck;

    private GameObject SailfishFollyFreeze;
    private float SlatStark= 120f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        SailfishFollyFreeze = NoseCheck.transform.Find("SlotCard_1").gameObject;
        float x= SlatStark * 3;
        int multiCount = BisHeadCar.instance.NoseTine.RewardMultiList.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(SailfishFollyFreeze, NoseCheck.transform);
                fangkuai.transform.localPosition = new Vector3(x + SlatStark * multiCount * i + SlatStark * j, SailfishFollyFreeze.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + BisHeadCar.instance.NoseTine.RewardMultiList[j].multi;
            }
        }
    }

    public void PramFolly()
    {
        NoseCheck.GetComponent<RectTransform>().localPosition = new Vector3(0, -10, 0);
    }

    public void Wind(int index, Action<int> finish)
    {
        TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.Sound_OneArmBandit);
        PrimitivePassageway.AccelerateInfant(NoseCheck, -(SlatStark * 2 + SlatStark * BisHeadCar.instance.NoseTine.RewardMultiList.Count * 3 + SlatStark * (index + 1)), () =>
        {
            finish?.Invoke(BisHeadCar.instance.NoseTine.RewardMultiList[index].multi);
        });
    }
}
