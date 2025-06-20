// Project: Plinko
// FileName: TuneCryCheckPassageway.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 15:50
// Description:

using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

public class TuneCryCheckPassageway : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("baseSlotObj")]    public GameObject PileTuneCry;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjList")]    public List<GameObject> WindCryRent;
[UnityEngine.Serialization.FormerlySerializedAs("rewardObjList")]

    public List<SlotRewardType> BurrowCryRent;
    
    private int FarImage;
    private int BurrowImage;


    private void Awake()
    {
        FarImage = 33;
        BurrowImage = 30;
    }

    private void Start()
    {
        NoseTine();
    }

    public void NoseTine()
    {
        for (int i = 0; i < FarImage; i++)
        {
            GameObject objItem = Instantiate(PileTuneCry, transform);
            Vector3 pos = new Vector3();
            pos.y = i - 2;
            objItem.transform.localPosition = pos;
            objItem.GetComponent<TuneCryPassageway>().NoseTineDoctor();
            WindCryRent.Add(objItem);
        }
    }

    public void WeldonAdviceCry(SlotRewardType rewardData)
    {

        
        for (int i = BurrowImage; i < FarImage; i++)
        {
            GameObject objItem = WindCryRent[i];

            if (i == BurrowImage)
            {
                objItem.GetComponent<TuneCryPassageway>().NoseTineOxTine(rewardData);
            }
            else
            {
                objItem.GetComponent<TuneCryPassageway>().NoseTineDoctor();
            }
        }
        
        BurrowCryRent = new List<SlotRewardType>();
        for (int i = BurrowImage-2; i < FarImage; i++)
        {
            GameObject objItem = WindCryRent[i];
            SlotRewardType tempData = objItem.GetComponent<TuneCryPassageway>().WindCryTine;
            BurrowCryRent.Add(tempData);
        }
        
    }

    public void MorallyTine()
    {
        // ClearData();
        MyNose();
    }

    private void MyNose()
    {
        for (int i = 0; i < FarImage; i++)
        {
            GameObject objItem = WindCryRent[i];
            if (i < 5)
            {
                SlotRewardType tarItem = BurrowCryRent[i];
                objItem.GetComponent<TuneCryPassageway>().NoseTineOxTine(tarItem);
            }
            else
            {
                objItem.GetComponent<TuneCryPassageway>().NoseTineDoctor();
            }
        }
    }

}