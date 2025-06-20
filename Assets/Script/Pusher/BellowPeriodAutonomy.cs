using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BellowPeriodAutonomy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup")]    public GameObject No_Magnitude;
[UnityEngine.Serialization.FormerlySerializedAs("text_Poolgroup")]    public GameObject Need_Magnitude;
    private void OnTriggerEnter(Collider other)
    {
        //GameObject fx = fx_Poolgroup.GetComponent<LoudScratch>().GetObject();
        //GameObject Text = text_Poolgroup.GetComponent<LoudScratch>().GetObject();
        //Text.SetActive(true);
        //fx.SetActive(true);
        //float V = (Screen.height * -0.587f) - 260;
        //Text.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        //Text.transform.localPosition = new Vector3(Text.transform.localPosition.x, Text.transform.localPosition.y, V);
        //Text.transform.position = new Vector3(other.gameObject.transform.position.x, -0.2f, Text.transform.position.z);
        //Text.transform.DOMoveY(1.5f, 0.7f).SetEase(Ease.OutQuad).OnComplete(()=> 
        //{
        //    Text.SetActive(false);
        //});
        //fx.transform.position = new Vector3 (other.gameObject.transform.position.x, -0.5f, -5.74f);

        GameObject pusherRewardItem = other.transform.parent.gameObject;
        Transform parent = pusherRewardItem.transform.parent;
        pusherRewardItem.SetActive(false);
        pusherRewardItem.transform.SetParent(PeriodScratch.Instance.BurrowBarkCheck);
        if (parent.childCount == 0)
        {
            Destroy(parent.gameObject);
        }
        if (pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.LuckyCard || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.ScratchCard || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.RollCash)
        {
            PeriodScratch.Instance.LeoPaceAdvice(pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear, pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowSod);
        }
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
