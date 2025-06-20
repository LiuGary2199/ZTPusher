using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class NucleusTine
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool GoodsGirl;
    public bool GoodsGirl2;
    public int GoodsGet;
    public int GoodsGet2;
    public int GoodsGet3;
    public float GoodsIndus;
    public float GoodsIndus2;
    public double GoodsExpend;
    public double GoodsExpend2;
    public string GoodsLaunch;
    public string GoodsLaunch2;
    public GameObject GoodsDramFreeze;
    public GameObject GoodsDramFreeze2;
    public GameObject GoodsDramFreeze3;
    public GameObject GoodsDramFreeze4;
    public Transform GoodsAssistant;
    public List<string> GoodsLaunchRent;
    public List<Vector2> GoodsTen2Rent;
    public List<int> GoodsGetRent;
    public System.Action NurseryReedRely;
    public Vector2 The2_1;
    public Vector2 The2_2;
    public NucleusTine()
    {
    }
    public NucleusTine(Vector2 v2_1)
    {
        The2_1 = v2_1;
    }
    public NucleusTine(Vector2 v2_1, Vector2 v2_2)
    {
        The2_1 = v2_1;
        The2_2 = v2_2;
    }
    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public NucleusTine(bool value)
    {
        GoodsGirl = value;
    }
    public NucleusTine(bool value, bool value2)
    {
        GoodsGirl = value;
        GoodsGirl2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public NucleusTine(int value)
    {
        GoodsGet = value;
    }
    public NucleusTine(int value, int value2)
    {
        GoodsGet = value;
        GoodsGet2 = value2;
    }
    public NucleusTine(int value, int value2, int value3)
    {
        GoodsGet = value;
        GoodsGet2 = value2;
        GoodsGet3 = value3;
    }
    public NucleusTine(List<int> value,List<Vector2> value2)
    {
        GoodsGetRent = value;
        GoodsTen2Rent = value2;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public NucleusTine(float value)
    {
        GoodsIndus = value;
    }
    public NucleusTine(float value,float value2)
    {
        GoodsIndus = value;
        GoodsIndus = value2;
    }
    /// <summary>
    /// 创建一个带double类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public NucleusTine(double value)
    {
        GoodsExpend = value;
    }
    public NucleusTine(double value, double value2)
    {
        GoodsExpend = value;
        GoodsExpend = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public NucleusTine(string value)
    {
        GoodsLaunch = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public NucleusTine(string value1,string value2)
    {
        GoodsLaunch = value1;
        GoodsLaunch2 = value2;
    }
    public NucleusTine(GameObject value1)
    {
        GoodsDramFreeze = value1;
    }

    public NucleusTine(Transform transform)
    {
        GoodsAssistant = transform;
    }
}

