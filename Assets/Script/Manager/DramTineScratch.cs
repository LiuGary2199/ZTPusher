using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramTineScratch : WhigSuccessor<DramTineScratch>
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void NoseDramTine()
    {
        NoseDonTine();

    }


    private void NoseDonTine()
    {
        if (AutoTineScratch.BuyLaunch(CBuckle.Go_AtNoseTine) != "done")
        {
            // 新用户 初始化数据
            AutoTineScratch.YouLaunch(CBuckle.Go_AtNoseTine, "done");
            // 新手引导
            AutoTineScratch.YouLaunch(CBuckle.Go_Secret_Few_Bush_Chalk, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Suit_Too_777, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_MoralTune, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Suit_Too_Burrow, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_Juicy_Fix_Fox, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Jolt_Fad, "new");
            AutoTineScratch.YouLaunch(CBuckle.Gem_Toss_Pink_us, "new");
            AutoTineScratch.YouLaunch(CBuckle.Go_Idiom_Wind_Abuse, "new");
            

            
            //收集物初始化
            AutoTineScratch.YouGet(GemsType.Blue.ToString(), 0);
            AutoTineScratch.YouGet(GemsType.Blue + "All", 0);
            AutoTineScratch.YouGet(GemsType.Yellow.ToString(), 0);
            AutoTineScratch.YouGet(GemsType.Yellow + "All", 0);
            AutoTineScratch.YouGet(GemsType.Silver.ToString(), 0);
            AutoTineScratch.YouGet(GemsType.Silver + "All", 0);
            AutoTineScratch.YouGet(GemsType.GoldBar.ToString(), 0);
            AutoTineScratch.YouGet(GemsType.GoldBar + "All", 0);
            
            // 余额初始化
            AutoTineScratch.YouExpend(CBuckle.Go_Gust, 0);
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessGust, 0);
            AutoTineScratch.YouExpend(CBuckle.Go_StirDeal, 0);
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessStirDeal, 0);
            AutoTineScratch.YouExpend(CBuckle.Go_Amazon, 0);
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessLitter, 0);
            AutoTineScratch.YouGet(CBuckle.Go_Farce_Soil_Cud, BisHeadCar.instance.DramTine.base_config.new_user_ball_count);
            AutoTineScratch.YouGet(CBuckle.Go_WildernessName, 30);
            
            AutoTineScratch.YouExpend(CBuckle.Go_bigwin_Attach_Clump, 1);
            
        }

        // 
        List<GemsDataItem> RowTineRent= BisHeadCar.instance.DramTine.Gem_Reward_list;
        foreach (GemsDataItem item in RowTineRent)
        {
            string gemType = item.gem_type;
            int gemMax = item.gem_limit;
            AutoTineScratch.YouGet(gemType + "Max", gemMax);
        }
    }

    // 金币
    public double BuyStir()
    {
        return AutoTineScratch.BuyExpend(CBuckle.Go_StirDeal);
    }

    public double BuyWildernessStirDeal()
    {
        return AutoTineScratch.BuyExpend(CBuckle.Go_WildernessStirDeal);
    }

    public void NorStir(double gold)
    {
        NorStir(gold, HuntScratch.Instance.transform);
    }

    public void NorStir(double gold, Transform startTransform)
    {
        double oldGold = AutoTineScratch.BuyExpend(CBuckle.Go_StirDeal);
        AutoTineScratch.YouExpend(CBuckle.Go_StirDeal, oldGold + gold);
        if (gold > 0)
        {
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessStirDeal,
                AutoTineScratch.BuyExpend(CBuckle.Go_WildernessStirDeal) + gold);
        }

        // NucleusTine md = new NucleusTine(oldGold);
        // md.valueTransform = startTransform;
        // NucleusCandidTribe.GetInstance().Send(CBuckle.mg_ui_addgold, md);
    }

    // 现金
    public double BuyGust()
    {
       // return AutoTineScratch.GetDouble(CBuckle.sv_Cash);
        return CashOutManager.BuyDuctless().Money;
    }
    
    public double BuyWildernessGust()
    {
        return AutoTineScratch.BuyExpend(CBuckle.Go_WildernessGust);
    }

    public void NorGust(double cash)
    {
        //AddCash(cash, HuntScratch.Instance.transform);
        CashOutManager.BuyDuctless().AddMoney((float)cash);
    }

    public void NorGust(double cash, Transform startTransform)
    {
        double oldCash = AutoTineScratch.BuyExpend(CBuckle.Go_Gust);
        double newCash = oldCash + cash;
        AutoTineScratch.YouExpend(CBuckle.Go_Gust, newCash);
        if (cash > 0)
        {
            double allCash = AutoTineScratch.BuyExpend(CBuckle.Go_WildernessGust);
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessGust, allCash + cash);
        }
//#if SOHOShop
//        SOHOShopManager.instance.UpdateCash();
//#endif
        // NucleusTine md = new NucleusTine(oldCash);
        // md.valueTransform = startTransform;
        // NucleusCandidTribe.GetInstance().Send(CBuckle.mg_ui_addtoken, md);
    }

    //Amazon卡
    public double BuyLitter()
    {
        return AutoTineScratch.BuyExpend(CBuckle.Go_Amazon);
    }
    
    public double BuyWildernessLitter()
    {
        return AutoTineScratch.BuyExpend(CBuckle.Go_WildernessLitter);
    }

    public void NorLitter(double amazon)
    {
        NorLitter(amazon, HuntScratch.Instance.transform);
    }

    public void NorLitter(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CBuckle.Go_Amazon)
            ? double.Parse(AutoTineScratch.BuyLaunch(CBuckle.Go_Amazon))
            : 0;
        double newAmazon = oldAmazon + amazon;
        AutoTineScratch.YouExpend(CBuckle.Go_Amazon, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = AutoTineScratch.BuyExpend(CBuckle.Go_WildernessLitter);
            AutoTineScratch.YouExpend(CBuckle.Go_WildernessLitter, allAmazon + amazon);
        }

        NucleusTine md = new NucleusTine(oldAmazon);
        md.GoodsAssistant = startTransform;
        NucleusCandidTribe.BuyDuctless().Salt(CBuckle.It_By_Excessive, md);
    }


    public int BuyName()
    {
        return AutoTineScratch.BuyGet(CBuckle.Go_Farce_Soil_Cud);
    }

    public void NorName(int num)
    {
        // AutoTineScratch.SetInt(CBuckle.sv_steel_ball_num, AutoTineScratch.GetInt(CBuckle.sv_steel_ball_num) + num);
        AutoTineScratch.YouGet(CBuckle.Go_WildernessName, AutoTineScratch.BuyGet(CBuckle.Go_WildernessName) + num);
    }


    public void NorWay(GemsType gemsType)
    {
        AutoTineScratch.YouGet(gemsType.ToString(), AutoTineScratch.BuyGet(gemsType.ToString()) + 1);
        AutoTineScratch.YouGet(gemsType + "All", AutoTineScratch.BuyGet(gemsType + "All") + 1);
        if (AutoTineScratch.BuyGet(gemsType.ToString()) == AutoTineScratch.BuyGet(gemsType + "Max"))
        {
            ChoppyCarryScratch.Instance.BuryFaintlyNevusPress();
        }

    }
}