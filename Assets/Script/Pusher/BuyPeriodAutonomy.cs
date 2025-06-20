using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BuyPeriodAutonomy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup")]    public GameObject No_Magnitude;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup_1")]    public GameObject No_Magnitude_1;
[UnityEngine.Serialization.FormerlySerializedAs("text_Poolgroup")]    public GameObject Need_Magnitude;
    private void OnTriggerEnter(Collider other)
    {
        GameObject pusherRewardItem = other.transform.parent.gameObject;
        if (pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.GemBlue || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.GemDiamond || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.GemRed || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.Golden)
        {
            Transform TargetTF = UIManager.BuyDuctless().HuntLatter.transform.Find("Normal/DramPress/Window/GemsStoreBtn").transform;
            GameObject WayScam= Resources.Load<GameObject>(CBuckle.Way_Scam).gameObject;
            GameObject WayBeg= Resources.Load<GameObject>(CBuckle.Way_Beg).gameObject;
            GameObject WayShortly= Resources.Load<GameObject>(CBuckle.Way_Shortly).gameObject;
            GameObject Icicle= Resources.Load<GameObject>(CBuckle.Way_Icicle).gameObject;
            GameObject fx_1 = No_Magnitude_1.GetComponent<LoudScratch>().BuyFreeze();
            fx_1.SetActive(true);
            fx_1.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            switch (pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear) 
            {
                case PusherRewardType.GemBlue:
                    PrimitivePassageway.SharperAdviceOwe(TargetTF.transform.position, WayScam, other.gameObject.transform.position, TargetTF,()=> { });
                    break;
                case PusherRewardType.GemDiamond:
                    PrimitivePassageway.SharperAdviceOwe(TargetTF.transform.position, WayShortly, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.GemRed:
                    PrimitivePassageway.SharperAdviceOwe(TargetTF.transform.position, WayBeg, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.Golden:
                    PrimitivePassageway.SharperAdviceOwe(TargetTF.transform.position, Icicle, other.gameObject.transform.position, TargetTF, () => { });
                    break;

            }
        }
        if (pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.CoinCash || pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.CoinGold)
        {
            GameObject fx = No_Magnitude.GetComponent<LoudScratch>().BuyFreeze();
            GameObject Text = Need_Magnitude.GetComponent<LoudScratch>().BuyFreeze();
            Text.SetActive(true);
            fx.SetActive(true);
            float V = (Screen.height * -0.587f) - 260;
            Text.transform.localScale = new Vector3(2f, 2f, 2f);
            Text.transform.localPosition = new Vector3(Text.transform.localPosition.x, Text.transform.localPosition.y - 2, V);
            Text.transform.position = new Vector3(other.gameObject.transform.position.x, -5f, Text.transform.position.z);
            Text.transform.DOMoveY(-4f + Random.Range(0, 1.5f), 0.7f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                Text.SetActive(false);
            });
            fx.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            if (pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear == PusherRewardType.CoinCash)
            {
                Text.GetComponent<Text>().color = new Color(4 / 255f, 1, 0);
                Text.GetComponent<Text>().text = "+" + System.Math.Round(pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowSod,2);
            }
            else
            {
                Text.GetComponent<Text>().color = new Color(237 / 255f, 1, 0); 
                Text.GetComponent<Text>().text = "+" + pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowSod;
            }
            
            
        }

        Transform parent = pusherRewardItem.transform.parent;
        pusherRewardItem.SetActive(false);
        pusherRewardItem.transform.SetParent(PeriodScratch.Instance.BurrowBarkCheck);
        if (parent.childCount == 0)
        {
            Destroy(parent.gameObject);
        }
        PeriodScratch.Instance.LeoPaceAdvice(pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowRear, pusherRewardItem.GetComponent<PeriodAdviceBark>().BurrowSod);
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
