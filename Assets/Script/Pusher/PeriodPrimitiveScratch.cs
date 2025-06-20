using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class PeriodPrimitiveScratch : MonoBehaviour
{
    static public PeriodPrimitiveScratch Instance;
[UnityEngine.Serialization.FormerlySerializedAs("push")]    public GameObject Hard;
[UnityEngine.Serialization.FormerlySerializedAs("slotBox")]    public GameObject WindWed;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallGroup")]    public GameObject ExistPeepCheck;
[UnityEngine.Serialization.FormerlySerializedAs("ballCreater")]    public NameImagery SoilImagery;
    Sequence HardMow;
    Sequence WindWedMow;
    float WeakenKeep= -2.0f;
    float MobKeep= -3f;
    float HardJeanUser= 1.5f;
    float HardChemurgy= 1f;
    float RarerCaneJeanUser= 0.3f;
    float RarerCaneChemurgy= 0f;
    float HardSea= -4.7f;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        Hard.transform.position = new Vector3(Hard.transform.position.x, Hard.transform.position.y, 0.5f);
        Pram_z = Hard.transform.position.z;
        WindWed.transform.localPosition = new Vector3(-1, WindWed.transform.localPosition.y, WindWed.transform.localPosition.z);
    }

    /// <summary>
    /// �ư��ʼλ��
    /// </summary>
    float Pram_z;
    /// <summary>
    /// ��ʼ�Ʊ�
    /// </summary>
    public void HardPlainJean(bool needRefresh = false)
    {
        HardMow.Kill();
        
        float moveZ = WeakenKeep;
        float time = HardJeanUser;
        float interval = HardChemurgy;
        if (GoSoNorKeep)
        {
            moveZ = MobKeep;
        }
        bool needBlock = false;
        
        if (PeriodScratch.Instance.GoCaneCraft)
        {
            time = RarerCaneJeanUser;
            interval = RarerCaneChemurgy; 
        }
        if (GoCaneSea)
        {
            time = HardJeanUser;
            GoCaneSea = false;
            moveZ = HardSea;
            needBlock = true;
        }
        HardMow = DOTween.Sequence();
        if (needRefresh)
        {
            HardMow.Append(Hard.GetComponent<Rigidbody>().DOMoveZ(Pram_z + moveZ, time * ((Pram_z + moveZ - Hard.transform.position.z) / moveZ)).SetEase(Ease.Linear));
        }
        else
        {
            HardMow.AppendInterval(interval);
            HardMow.Append(Hard.GetComponent<Rigidbody>().DOMoveZ(Pram_z + moveZ, time).SetEase(Ease.Linear));
        }
        HardMow.AppendInterval(interval);
        HardMow.Append(Hard.GetComponent<Rigidbody>().DOMoveZ(Pram_z, time).SetEase(Ease.Linear));
        HardMow.AppendCallback(() =>
        {
            if (needBlock)
            {
                HardSeaInside();
            }
            HardPlainJean();
        });
        HardMow.Play();

    }
    /// <summary>
    /// ��ͣ�Ʊ�
    /// </summary>
    public void HardBulgeJean()
    {
        HardMow.Pause();
        WindWedMow.Pause();
    }
    /// <summary>
    /// �ָ��Ʊ�
    /// </summary>
    public void HardMaracaJean()
    {
        HardMow.Play();
        WindWedMow.Play();
    }


    /// <summary>
    /// �Ƿ����ӳ�״̬
    /// </summary>
    bool GoSoNorKeep= false;
    /// <summary>
    /// ����ӳ��ĳ���ʱ��
    /// </summary>
    float MobKeepUser= 0;
    /// <summary>
    /// �ӳ��ư忪ʼ(��ʼ��������ʱ/ˢ�¶���״̬)
    /// </summary>
    /// <param name="time"></param>
    public void HardNorKeep(float time)
    {
        MobKeepUser += time;
        TineAnnualScratch.BuyDuctless().TossTreadKeepUser(!GoSoNorKeep, (int)time);
        if (!GoSoNorKeep)
        {
            GoSoNorKeep = true;
            float alreadyPlay = HardMow.ElapsedPercentage();
            if (alreadyPlay < 0.5f)
            {
                HardPlainJean(true);
            }
            StartCoroutine(nameof(MobKeepAnyLampUser));
        }
    }
    /// <summary>
    /// ��ʱ�رռӳ�
    /// </summary>
    /// <returns></returns>
    IEnumerator MobKeepAnyLampUser()
    {
        float t = 0;
        while (t < MobKeepUser)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        MobKeepUser = 0;
        GoSoNorKeep = false;
    }


    /// <summary>
    /// �Ƿ��Ѿ�����ǽ
    /// </summary>
    bool GoSoPeepAn= false;
    /// <summary>
    /// ǽ����ʣ��ʱ��
    /// </summary>
    float SoonAnUser= 0;
    /// <summary>
    /// ����ǽ����
    /// </summary>
    /// <param name="time"></param>
    public void FenPeepAn(float time)
    {
        SoonAnUser += time;
        TineAnnualScratch.BuyDuctless().TossTreadPeepUser(!GoSoPeepAn, (int)time);
        if (!GoSoPeepAn)
        {
            ExistPeepCheck.transform.DOMoveY(0, 0.3f);
            StartCoroutine(nameof(SoonAnAnyLampUser));
        }
    }
    /// <summary>
    /// ����ǽ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator SoonAnAnyLampUser()
    {
        int t = 0;
        while (t < SoonAnUser)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        SoonAnUser = 0;
        GoSoPeepAn = false;
        FenPeepSalt();
    }
    /// <summary>
    /// ����ǽ����
    /// </summary>
    public void FenPeepSalt()
    {
        ExistPeepCheck.transform.DOMoveY(-0.8f, 0.3f);
    }


    /// <summary>
    /// �Ƿ���Ҫȫ������
    /// </summary>
    bool GoCaneSea= false;
    /// <summary>
    /// ȫ�����»ص�
    /// </summary>
    System.Action HardSeaInside;
    /// <summary>
    /// ȫ������
    /// </summary>
    public void HardSeaJean(System.Action block)
    {
        HardSeaInside = block;
        GoCaneSea = true;
        float alreadyPlay = HardMow.ElapsedPercentage();
        if (alreadyPlay < 0.5f)
        {
            HardPlainJean(true);
        }
    }


    

    /// <summary>
    /// slot�п�ʼ�ƶ�
    /// </summary>
    public void FoxPlainJean()
    {
        float moveX = 2f;
        float x= WindWed.transform.position.x;
        WindWedMow = DOTween.Sequence();
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DOMoveX(x + moveX, 2));
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 90), 0.5f));
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        WindWedMow.AppendInterval(0.5f);
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DOMoveX(x, 2));
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, -90), 0.5f));
        WindWedMow.Append(WindWed.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        WindWedMow.AppendInterval(0.5f);
        WindWedMow.SetLoops(-1);
        WindWedMow.Play();
    }
    /// <summary>
    /// ��ͣslot��
    /// </summary>
    public void WindWedBulgeJean()
    {
        WindWedMow.Pause();
    }
    /// <summary>
    /// �ָ�slot��
    /// </summary>
    public void WindWedMaracaJean()
    {
        WindWedMow.Restart();
    }

    /// <summary>
    /// slot�йر�
    /// </summary>
    public void ShaftTuneWed()
    {
        WindWed.SetActive(false);
    }


    void Start()
    {
        //�趨�ư��ʼλ��
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
