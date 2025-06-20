/*
 *主题： 消息（传递）中心
 *    Description: 
 *           功能： 负责UI框架中，所有UI窗体中间的数据传值
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleusCandid 
{
    //委托：消息传递
    public delegate void DelMessageDelivery(KeyValuesUpdate kv);

    //消息中心缓存集合
    public static Dictionary<string, DelMessageDelivery> _dicColossal= new Dictionary<string, DelMessageDelivery>();

    /// <summary>
    /// 增加消息的监听
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public static void NorMsgSubtlety(string messageType,DelMessageDelivery handler)
    {
        if (!_dicColossal.ContainsKey(messageType))
        {
            _dicColossal.Add(messageType, null);
        }
        _dicColossal[messageType] += handler;
    }

    /// <summary>
    /// 取消消息的监听
    /// </summary>
    /// <param name="messageType">消息的分类</param>
    /// <param name="handler">消息委托</param>
    public static void BellowSexSubtlety(string messageType,DelMessageDelivery handler)
    {
        if (_dicColossal.ContainsKey(messageType))
        {
            _dicColossal[messageType] -= handler;
        }
    }

    /// <summary>
    /// 取消所有指定消息的监听
    /// </summary>
    public static void AssetSeaSexSubtlety()
    {
        if (_dicColossal != null)
        {
            _dicColossal.Clear();
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="messageType">消息的分类</param>
    /// <param name="kv">键值对(对象)</param>
    public static void SaltNucleus(string messageType,KeyValuesUpdate kv)
    {
        DelMessageDelivery del;
        if(_dicColossal.TryGetValue(messageType,out del))
        {
            if (del != null)
            {
                del(kv);
            }
        }
    }
}
/// <summary>
/// 键值更新对
/// 功能：配合委托实现委托数据传递
/// </summary>
public class KeyValuesUpdate
{
    //键
    private string _Sod;
    //值
    private object _Indium;
    //只读属性
    public string Sod    {
        get
        {
            return _Sod;
        }
    }
    public object Indium    {
        get
        {
            return _Indium;
        }
    }
    public KeyValuesUpdate(string key, object valueObj)
    {
        _Sod = key;
        _Indium = valueObj;
    }
}
