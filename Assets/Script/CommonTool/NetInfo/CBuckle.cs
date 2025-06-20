/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBuckle
{
    #region 常量字段
    //登录url
    public const string FacetBay= "/api/client/user/getId?gameCode=";
    //配置url
    public const string BuckleBay= "/api/client/config?gameCode=";
    //时间戳url
    public const string UserBay= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string ElicitBay= "/api/client/user/setAdjustId?gameCode=";
    
    public const string sys_Covering= "sys_language";

    public const string Toe_FeeSH= "sys_AppSH";
    #endregion

    #region 本地存储的字符串


    public const string Go_AtNoseTine= "sv_IsInitData";

    public const string Go_Toy_Too_Jolt= "sv_big_win_cash";
    
    public const string msg_Guard_Troop_Kit_Juicy= "msg_close_panel_and_start";

    public const string Go_Rarer_Drug_Chronic= "sv_fever_time_current";

    public const string Go_Secret_Few_Bush_Chalk= "sv_finish_new_user_guide";

    public const string Go_bigwin_Attach_Clump= "sv_bigwin_weight_multi";
    
    
    
    
    
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string Go_DozenPontIt= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Go_DozenShrinkIt= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Go_AtDonWhence= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Go_StrapTulipBuyPaint= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Go_StrapTulipCoal= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Go_DonPontKiln= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Go_StirDeal= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Go_WildernessStirDeal= "sv_CumulativeGoldCoin";
    
    public const string Go_Gust= "sv_Cash";

    public const string Go_WildernessGust= "sv_CumulativeCash";

    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Go_Amazon= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Go_WildernessLitter= "sv_CumulativeAmazon";
    
    public const string Go_Farce_Soil_Cud= "sv_steel_ball_num";

    public const string Go_WildernessName= "sv_CumulativeBall";
    
    public const string Go_Farce_Soil_Hike= "sv_steel_ball_date";
    
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Go_CrawlDramUser= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Go_MoralBuySweet= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Go_HasBuryMailPress= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Go_WildernessActress= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Go_PetioleAideEmpire= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Go_DonPontKilnInside= "sv_NewUserStepFinish";
    public const string Go_Rote_Stint_Daily= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Go_MoralTune= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Go_ElicitFend= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Go_ID_Hotel_Cud= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Go_Alter_ID_Cud= "sv_total_ad_num";


    public const string Go_Idiom_Suit_Too_777= "sv_first_bing_win_777";
    
    public const string Go_Idiom_Suit_Too_Burrow= "sv_first_bing_win_reward";
    public const string Gem_Toss_Jolt_Zone= "msg_show_cash_mask";
    public const string Go_Juicy_Fix_Fox= "sv_start_fiy_box";
    public const string Go_Idiom_Jolt_Fad= "sv_first_cash_out";
    public const string Gem_Toss_Pink_us= "msg_show_rate_us";
    public const string Go_Idiom_Wind_Abuse= "sv_first_slot_again";
    public const string Go_Weaken_Too_ID_Go= "sv_normal_win_ad_id";
    public const string Go_Weaken_Too_Drip= "sv_normal_win_type";
    public const string Go_Wing_Drip= "sv_gems_type";
    public const string Go_Shyness_Mob_Soil= "sv_first_add_ball";
    
    
    
    
    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string mg_MemoryGibe= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string It_MemoryShaft= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string It_By_Thermodynamic= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string It_By_Outcrop= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string It_By_Catalyst= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string It_By_Excessive= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string It_DramStartle= "mg_GameSuspend";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string Clip_StirDeal_Trance= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Clip_Sweet_Trance_Unread= "Art/Tex/UI/jiangli4";

    public static string Way_Scam= "Prefab/Way_Scam";
    public static string Way_Beg= "Prefab/Way_Beg";
    public static string Way_Shortly= "Prefab/Way_Shortly";
    public static string Way_Icicle= "Prefab/Icicle";
    public static string Who_10= "Art/Tex/Who_10";
    public static string Who_8= "Art/Tex/Who_8";
    public static string WedPaint= "Art/Tex/BoxCount/x";

    #endregion
}

