/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FreezeLoudScratch : WhigSuccessor<FreezeLoudScratch>
{
    //管理objectpool的字典
    private Dictionary<string, FreezeLoud> m_LoudTed;
    private Transform m_FineAssistant=null;
    //构造函数
    public FreezeLoudScratch()
    {
        m_LoudTed = new Dictionary<string, FreezeLoud>();      
    }
    
    //创建一个新的对象池
    public T WeldonFreezeLoud<T>(string poolName) where T : FreezeLoud, new()
    {
        if (m_LoudTed.ContainsKey(poolName))
        {
            return m_LoudTed[poolName] as T;
        }
        if (m_FineAssistant == null)
        {
            m_FineAssistant = this.transform;
        }      
        GameObject obj = new GameObject(poolName);
        obj.transform.SetParent(m_FineAssistant);
        T Pray= new T();
        Pray.Nose(poolName, obj.transform);
        m_LoudTed.Add(poolName, Pray);
        return Pray;
    }
    //取对象
    public GameObject BuyDramFreeze(string poolName)
    {
        if (m_LoudTed.ContainsKey(poolName))
        {
            return m_LoudTed[poolName].Buy();
        }
        return null;
    }
    //回收对象
    public void CounterDramFreeze(string poolName,GameObject go)
    {
        if (m_LoudTed.ContainsKey(poolName))
        {
            m_LoudTed[poolName].Counter(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_LoudTed.Clear();
        GameObject.Destroy(m_FineAssistant);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool ShelfLoud(string poolName)
    {
        return m_LoudTed.ContainsKey(poolName) ? true : false;
    }
}
