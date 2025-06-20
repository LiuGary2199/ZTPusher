/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfantLobe : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public Bark SlatHone;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect HandleObey;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Formula;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Further= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float AlterStark;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float AlterRename;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int CompanyPaint;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool GoMoat= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int JuicyImage;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int FootImage;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float SlatRename= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<Bark> SlatRent;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<Bark> CompanyRent;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> CabRent;

    void Start()
    {
        AlterRename = this.GetComponent<RectTransform>().sizeDelta.y;
        AlterStark = this.GetComponent<RectTransform>().sizeDelta.x;
        Formula = HandleObey.content;
        NoseTine();

    }
    //初始化
    public void NoseTine()
    {
        CompanyPaint = Mathf.CeilToInt(AlterRename / OpenRename) + 1;
        for (int i = 0; i < CompanyPaint; i++)
        {
            this.NorBark();
        }
        JuicyImage = 0;
        FootImage = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        YouTine(numberList);
    }
    //设置数据
    void YouTine(List<int> list)
    {
        CabRent = list;
        JuicyImage = 0;
        if (TinePaint <= CompanyPaint)
        {
            FootImage = TinePaint;
        }
        else
        {
            FootImage = CompanyPaint - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = JuicyImage; i < FootImage; i++)
        {
            Bark obj = WarBark();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * OpenRename, 0);
                CompanyRent.Add(obj);
                ManualBark(i, obj);
            }

        }
        Formula.sizeDelta = new Vector2(AlterStark, TinePaint * OpenRename - Further);
        GoMoat = true;
    }
    //更新item
    public void ManualBark(int index, Bark obj)
    {
        int d = CabRent[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public Bark WarBark()
    {
        Bark obj = null;
        if (SlatRent.Count > 0)
        {
            obj = SlatRent[0];
            obj.gameObject.SetActive(true);
            SlatRent.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void CaneBark(Bark obj)
    {
        SlatRent.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int TinePaint    {
        get
        {
            return CabRent.Count;
        }
    }
    //每一行的高
    public float OpenRename    {
        get
        {
            return SlatRename + Further;
        }
    }
    //添加item到缓存列表中
    public void NorBark()
    {
        GameObject obj = Instantiate(SlatHone.gameObject);
        obj.transform.SetParent(Formula);
        RectTransform Stag= obj.GetComponent<RectTransform>();
        Stag.anchorMin = new Vector2(0.5f, 1);
        Stag.anchorMax = new Vector2(0.5f, 1);
        Stag.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        Bark o = obj.GetComponent<Bark>();
        SlatRent.Add(o);
    }



    void Update()
    {
        if (GoMoat)
        {
            Infant();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Infant()
    {
        float vy = Formula.anchoredPosition.y;
        float rollUpTop = (JuicyImage + 1) * OpenRename;
        float rollUnderTop = JuicyImage * OpenRename;

        if (vy > rollUpTop && FootImage < TinePaint)
        {
            //上边界移除
            if (CompanyRent.Count > 0)
            {
                Bark obj = CompanyRent[0];
                CompanyRent.RemoveAt(0);
                CaneBark(obj);
            }
            JuicyImage++;
        }
        float rollUpBottom = (FootImage - 1) * OpenRename - Further;
        if (vy < rollUpBottom - AlterRename && JuicyImage > 0)
        {
            //下边界减少
            FootImage--;
            if (CompanyRent.Count > 0)
            {
                Bark obj = CompanyRent[CompanyRent.Count - 1];
                CompanyRent.RemoveAt(CompanyRent.Count - 1);
                CaneBark(obj);
            }

        }
        float rollUnderBottom = FootImage * OpenRename - Further;
        if (vy > rollUnderBottom - AlterRename && FootImage < TinePaint)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            Bark go = WarBark();
            CompanyRent.Add(go);
            go.transform.localPosition = new Vector3(0, -FootImage * OpenRename);
            ManualBark(FootImage, go);
            FootImage++;
        }


        if (vy < rollUnderTop && JuicyImage > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            JuicyImage--;
            Bark go = WarBark();
            CompanyRent.Insert(0, go);
            ManualBark(JuicyImage, go);
            go.transform.localPosition = new Vector3(0, -JuicyImage * OpenRename);
        }

    }
}
