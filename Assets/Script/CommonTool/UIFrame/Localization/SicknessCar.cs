/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicknessCar 
{
    public static SicknessCar _Vagueness;
    //语言翻译的缓存集合
    private Dictionary<string, string> _TedSicknessIssue;

    private SicknessCar()
    {
        _TedSicknessIssue = new Dictionary<string, string>();
        //初始化语言缓存集合
        NoseSicknessIssue();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static SicknessCar BuyDuctless()
    {
        if (_Vagueness == null)
        {
            _Vagueness = new SicknessCar();
        }
        return _Vagueness;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string BuryAfar(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_TedSicknessIssue!=null && _TedSicknessIssue.Count >= 1)
        {
            _TedSicknessIssue.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void NoseSicknessIssue()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IBuckleScratch config = new BuckleScratchOxOnto("LauguageJSONConfig");
        if (config != null)
        {
            _TedSicknessIssue = config.FeeHygiene;
        }
    }
}
