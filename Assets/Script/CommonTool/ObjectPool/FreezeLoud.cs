/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeLoud 
{
    private Queue<GameObject> m_LoudFlora;
    //池子名称
    private string m_LoudStep;
    //父物体
    protected Transform m_Rattle;
    //缓存对象的预制体
    private GameObject Mosaic;
    //最大容量
    private int m_ShePaint;
    //默认最大容量
    protected const int m_ContendShePaint= 20;
    public GameObject Kennel    {
        get => Mosaic;set { Mosaic = value;  }
    }
    //构造函数初始化
    public FreezeLoud()
    {
        m_ShePaint = m_ContendShePaint;
        m_LoudFlora = new Queue<GameObject>();
    }
    //初始化
    public virtual void Nose(string poolName,Transform transform)
    {
        m_LoudStep = poolName;
        m_Rattle = transform;
    }
    //取对象
    public virtual GameObject Buy()
    {
        GameObject obj;
        if (m_LoudFlora.Count > 0)
        {
            obj = m_LoudFlora.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Mosaic);
            obj.transform.SetParent(m_Rattle);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Counter(GameObject obj)
    {
        if (m_LoudFlora.Contains(obj)) return;
        if (m_LoudFlora.Count >= m_ShePaint)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_LoudFlora.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void CounterSea()
    {
        Transform[] child = m_Rattle.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Rattle)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Counter(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Cynthia()
    {
        m_LoudFlora.Clear();
    }
}
