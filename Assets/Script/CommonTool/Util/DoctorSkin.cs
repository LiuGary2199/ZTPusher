using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorSkin
{
    /// <summary>
    /// 带权随机
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="objs"></param>
    /// <param name="weights"></param>
    /// <returns></returns>
    public static T BuyMirageDoctor<T>(T[] objs, int[] weights)
    {
        int randomIndex = BuyMirageDoctorImage(objs, weights);
        return objs[randomIndex];
    }

    public static int BuyMirageDoctorImage<T>(T[] objs, int[] weights)
    {
        List<int> indexes = new List<int>();
        int totalWeight = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (i >= objs.Length)
            {
                break;
            }
            int Attach= weights[i];
            for (int j = 0; j < Attach; j++)
            {
                indexes.Add(i);
            }
            totalWeight += Attach;
        }

        int randomIndex = Random.Range(0, totalWeight);
        return indexes[randomIndex];
    }

    public static int BuyMirageDoctorImage<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return BuyMirageDoctorImage(keys, values);
    }

    public static T BuyMirageDoctor<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return BuyMirageDoctor(keys, values);
    }



    public static bool SoSeeker(float chance)
    {
        return Random.Range(0, 100) <= chance * 100;
    }
    
    public static List<T> DoctorRoam<T>(List<T> list)
    {
        var random = new System.Random();
        var newList = new List<T>();
        foreach (var item in list)
        {
            newList.Insert(random.Next(newList.Count),item);
        }
        return newList;
    }
    
}
