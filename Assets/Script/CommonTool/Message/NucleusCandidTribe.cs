using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class NucleusCandidTribe:WhigSuccessor<NucleusCandidTribe>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<NucleusTine>> DepartmentNucleus;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private NucleusCandidTribe()
    {
        NoseTine();
    }

    private void NoseTine()
    {
        //初始化消息字典
        DepartmentNucleus = new Dictionary<string, Action<NucleusTine>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Clearing(string key, Action<NucleusTine> action)
    {
        if (!DepartmentNucleus.ContainsKey(key))
        {
            DepartmentNucleus.Add(key, null);
        }
        DepartmentNucleus[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Bellow(string key, Action<NucleusTine> action)
    {
        if (DepartmentNucleus.ContainsKey(key) && DepartmentNucleus[key] != null)
        {
            DepartmentNucleus[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Salt(string key, NucleusTine data = null)
    {
        if (DepartmentNucleus.ContainsKey(key) && DepartmentNucleus[key] != null)
        {
            DepartmentNucleus[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Asset()
    {
        DepartmentNucleus.Clear();
    }
}
