using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoudScratch : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("pool")]    public List<GameObject> Pray;
[UnityEngine.Serialization.FormerlySerializedAs("prefab")]    public GameObject Mosaic;
    private Transform MosaicRattle;
    private string AnchorStep;

    public void NoseLoudScratch(GameObject obj, Transform parent, int count, string _objectName)
    {
        Mosaic = obj;
        AnchorStep = _objectName;
        Pray = new List<GameObject>();
        MosaicRattle = parent;
        int JuicyImage= 0;
        for (int k = 0; k < MosaicRattle.childCount; k++)
        {
            if (MosaicRattle.GetChild(k).name.Contains(AnchorStep))
            {
                Pray.Add(MosaicRattle.GetChild(k).gameObject);
                JuicyImage++;
            }
        }
        for (int i = JuicyImage; i < count; i++)
        {
            GameObject objClone = GameObject.Instantiate(Mosaic, MosaicRattle) as GameObject;
            //objClone.transform.parent = prefabParent;//为克隆出来的子弹指定父物体
            objClone.name = AnchorStep + "(" + i.ToString() + ")";
            objClone.SetActive(false);
            Pray.Add(objClone);
        }
    }
    public void AssumeLoudNorBark(GameObject obj)
    {
        Pray.Add(obj);
    }

    public GameObject BuyFreeze()
    {
        //遍历缓存池 找空闲的物体
        foreach (GameObject iter in Pray)
        {
            if (iter != null && !iter.activeSelf)
            {
                iter.transform.SetParent(MosaicRattle);
                iter.SetActive(true);
                return iter;
            }
        }
        GameObject newPrefab = GameObject.Instantiate(Mosaic) as GameObject;
        newPrefab.transform.SetParent(MosaicRattle);
        newPrefab.name = AnchorStep + "(" + Pray.Count.ToString() + ")"  ;
        newPrefab.SetActive(true);
        Pray.Add(newPrefab);
        return newPrefab;
    }

    public void ShaftSea()
    {
        foreach (GameObject iter in Pray)
        {
            if (iter.activeSelf)
            {
                iter.SetActive(false);
            }
        }
    }
    public void CynthiaSea()
    {
        foreach (GameObject iter in Pray)
        {
            Destroy(iter);
        }
        Destroy(MosaicRattle);
        Destroy(this.gameObject);
    }
}
