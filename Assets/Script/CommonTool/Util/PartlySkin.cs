using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PartlySkin
{
    public static string ExpendAnSad(double a)
    {
        return Math.Round(a, VacantBuckle.BeachRodent).ToString();
    }

    public static double Beach(double a)
    {
        return Math.Round(a, VacantBuckle.BeachRodent);
    }

    public static double FoeFreely(string key)
    {
        string s = PlayerPrefs.GetString(key);
        double result = 0;
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ",";

        if (double.TryParse(s, NumberStyles.Any, nfi, out result))
        {
            Debug.Log($"转换结果: {result}");
        }
        else
        {
            Debug.Log($"转换失败:" + s);
        }
        return string.IsNullOrEmpty(s) ? 0 : result;
    }
    public static float FoeFreelyFloat(string key)
    {
        string s = PlayerPrefs.GetString(key);
        float result = 0;
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ",";

        if (float.TryParse(s, NumberStyles.Any, nfi, out result))
        {
            Debug.Log($"转换结果: {result}");
        }
        else
        {
            Debug.Log($"转换失败: {s}");
        }
        return string.IsNullOrEmpty(s) ? 0 : result;
    }
}
