﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCooperImagery : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("coinPagodaPerfab")]    public GameObject SparCooperEither;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void VaporDealCooper(int heightCount)
    {
        bool isUnlock = false;
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> eulerList = new List<Vector3>();
        for (int i = 0; i < SparCooperEither.transform.childCount; i++)
        {
            Transform targetTrans = SparCooperEither.transform.GetChild(i);
            pointList.Add(targetTrans.localPosition);
            eulerList.Add(targetTrans.eulerAngles);
        }
        GameObject pagodaGroup = new GameObject();
        pagodaGroup.AddComponent<UpsideCooper>().Ample = ()=> {
            if (!isUnlock)
            {
                isUnlock = true;
                pagodaGroup.GetComponent<UpsideCooper>().enabled = false;
                Destroy(pagodaGroup.GetComponent<Rigidbody>());
                for (int i = 0; i < pagodaGroup.transform.childCount; i++)
                {
                    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
                    cashCoin.AddComponent<Rigidbody>();
                    cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
                    cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
                }
            }
        };
        pagodaGroup.layer = 6;
        pagodaGroup.AddComponent<Rigidbody>().mass = 30;
        pagodaGroup.transform.position = new Vector3(0, 0.74f, -3.671f);
        pagodaGroup.transform.SetParent(PeriodScratch.Instance.BurrowBarkCheck);
        for (int i = 0; i < heightCount; i++)
        {
            GameObject tempObject = new GameObject();
            for (int j = 0; j < 7; j++)
            {
                GameObject cashCoin = PeriodScratch.Instance.LeoAdviceBark(PusherRewardType.CoinCash);
                cashCoin.transform.SetParent(tempObject.transform);
                cashCoin.transform.localPosition = pointList[j];
                cashCoin.transform.eulerAngles = eulerList[j];
                Destroy(cashCoin.GetComponent<Rigidbody>());
            }
            tempObject.transform.position = pagodaGroup.transform.position + new Vector3(0, 0.1074f * i, 0);
            tempObject.transform.eulerAngles = new Vector3(0, i * 3, 0);
            for (int k = tempObject.transform.childCount - 1; k >= 0; k--)
            {
                tempObject.transform.GetChild(k).SetParent(pagodaGroup.transform);
            }
            Destroy(tempObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            VaporDealCooper(30);
        }
    }
}
