// Project: Pusher
// FileName: FaintlyNevusPress.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:20
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaintlyNevusPress : ForkUIVisit
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button GuardOak;
[UnityEngine.Serialization.FormerlySerializedAs("objList")]
    public List<GameObject> objRent;

    private List<GemsDataItem> RowTineRent;
    private void Start()
    {
        GuardOak.onClick.AddListener(() =>
        {
            ShaftPress();
        });
        
        
        NucleusCandidTribe.BuyDuctless().Clearing(CBuckle.msg_Guard_Troop_Kit_Juicy,
            (messageData) => {ShaftPress(); });

    }


    protected override void Awake()
    {
        base.Awake();
        RowTineRent = BisHeadCar.instance.DramTine.Gem_Reward_list;
    }

    public override void Display()
    {
        base.Display();
        ADScratch.Ductless.BulgeUserRemuneration();
        NoseTine();
    }

    private void NoseTine()
    {
        for (int i = 0; i < objRent.Count; i++)
        {
            GameObject objItem = objRent[i];
            objItem.GetComponent<FaintlyCryPassageway>().WingTineBark = RowTineRent[i];
            objItem.GetComponent<FaintlyCryPassageway>().NoseTine();
        }
    }


    private void ShaftPress()
    {
        NoseTine();
        HuntScratch.Instance.DramWitness();
        ShaftUIWish(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADScratch.Ductless.MaracaUserRemuneration();
    }
}