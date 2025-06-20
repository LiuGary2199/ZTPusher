using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class CardHonorDecode : WhigSuccessor<CardHonorDecode>
{
    public string Similar= "1.2";
    public string DramBomb= BisHeadCar.instance.DramBomb;
    //channel
#if UNITY_IOS
    private string Anxiety= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        CardHonorDecode.BuyDuctless().CropDramEmigrant();
    }
    
    public Text Need;

    protected override void Awake()
    {
        base.Awake();
        
        Similar = Application.version;
        StartCoroutine(nameof(RimeNucleus));
    }
    IEnumerator RimeNucleus()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            CardHonorDecode.BuyDuctless().CropDramEmigrant();
        }
    }
    private void Start()
    {
        if (AutoTineScratch.BuyGet("event_day") != DateTime.Now.Day && AutoTineScratch.BuyLaunch("user_servers_id").Length != 0)
        {
            AutoTineScratch.YouGet("event_day", DateTime.Now.Day);
        }
    }
    public void SaltGoWavyHonor(string event_id)
    {
        SaltHonor(event_id);
    }
    public void CropDramEmigrant(List<string> valueList = null)
    {
        if (AutoTineScratch.BuyExpend(CBuckle.Go_WildernessStirDeal) == 0)
        {
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessStirDeal, AutoTineScratch.BuyExpend(CBuckle.Go_StirDeal));
        }
        if (AutoTineScratch.BuyExpend(CBuckle.Go_Gust) == 0)
        {
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessGust, AutoTineScratch.BuyExpend(CBuckle.Go_WildernessGust));
        }
        if (valueList == null)
        {
            valueList = new List<string>() { 
                
                DramTineScratch.BuyDuctless().BuyStir().ToString(),
                DramTineScratch.BuyDuctless().BuyGust().ToString(),
                DramTineScratch.BuyDuctless().BuyWildernessStirDeal().ToString(),
                DramTineScratch.BuyDuctless().BuyWildernessGust().ToString(),
                DramTineScratch.BuyDuctless().BuyWildernessLitter().ToString(),
                AutoTineScratch.BuyGet("DropBallCount").ToString(),
          
            };
        }
        
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", DramBomb);
        wwwForm.AddField("userId", AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt));

        wwwForm.AddField("gameVersion", Similar);

        wwwForm.AddField("channel", Anxiety);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(SaltCard(BisHeadCar.instance.ForkBay + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void SaltHonor(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Need != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Need.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt) == null)
        {
            BisHeadCar.instance.Facet();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", DramBomb);
        wwwForm.AddField("userId", AutoTineScratch.BuyLaunch(CBuckle.Go_DozenShrinkIt));
        //Debug.Log("userId:" + AutoTineScratch.GetString(CBuckle.sv_LocalServerId));
        wwwForm.AddField("version", Similar);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Anxiety);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(SaltCard(BisHeadCar.instance.ForkBay + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator SaltCard(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            LogNeutral();
        }
        else
        {
            success(request.downloadHandler.text);
            LogNeutral();
        }
    }
    private void LogNeutral()
    {
        StopCoroutine("SendGet");
    }


}