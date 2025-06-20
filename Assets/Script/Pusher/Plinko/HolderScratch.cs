using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolderScratch : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("shootPoint")]    public GameObject ChildSteep;
[UnityEngine.Serialization.FormerlySerializedAs("ballPerfab")]    public GameObject SoilEither;
[UnityEngine.Serialization.FormerlySerializedAs("ballPanel")]    public GameObject SoilPress;
[UnityEngine.Serialization.FormerlySerializedAs("plateWidth")]    public float SkullStark;
[UnityEngine.Serialization.FormerlySerializedAs("allWidth")]    public float CabStark;
[UnityEngine.Serialization.FormerlySerializedAs("allBoxList")]    public List<HolderDealImagery> CabWedRent;
[UnityEngine.Serialization.FormerlySerializedAs("ballPool")]    public LoudScratch SoilLoud;
    bool SkateClue;
    static public HolderScratch Instance;
    private void Awake()
    {
        Instance = this;
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="drop_x"></param>
    public void WoldName(float drop_x)
    {
        if (PeriodScratch.Instance.GoBulge)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.MediumImpact);
        float scale = 0.45f;
        GameObject ball = SoilLoud.BuyFreeze();
        ball.transform.position = new Vector3(drop_x, ChildSteep.transform.position.y, ChildSteep.transform.position.z);
        ball.transform.localScale = new Vector3(scale, scale, scale);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20));
    }

    public void PaceDeal(float drop_x)
    {
        if (PeriodScratch.Instance.GoBulge)
        {
            return;
        }
        GameObject coin = PeriodScratch.Instance.LeoAdviceBark(PusherRewardType.CoinGold);
        coin.transform.position = new Vector3(drop_x, 8f, -1f);
        coin.transform.eulerAngles = new Vector3(LeoDebtorDoctor(), LeoDebtorDoctor(), LeoDebtorDoctor());
        coin.GetComponent<Rigidbody>().AddForce(0f, -5f, 0f);
        if (!PeriodScratch.Instance.GoCaneCraft)
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            TheirCar.BuyDuctless().ExamSinger(TheirRear.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
    }
    /// <summary>
    /// ���������
    /// </summary>
    /// <returns></returns>
    IEnumerator SkateUpsideLampUser()
    {
        yield return new WaitForSeconds(PartlySkin.FoeFreelyFloat(BisHeadCar.instance.DramTine.base_config.touch_cd));
        SkateClue = false;
    }

    /// <summary>
    /// ��ͣȫ��С��
    /// </summary>
    public void DrainSeaName()
    {
        for (int i = 0; i < SoilLoud.Pray.Count; i++)
        {
            SoilLoud.Pray[i].GetComponent<InfectionBulge>().DrainRigidbody();
        }
    }
    /// <summary>
    /// �ָ�ȫ��С��
    /// </summary>
    public void AlwaysSeaName()
    {
        for (int i = 0; i < SoilLoud.Pray.Count; i++)
        {
            SoilLoud.Pray[i].GetComponent<InfectionBulge>().AlwaysInfection();
        }
    }


    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void RarerPlainWedMorally(int c)
    {
        foreach (HolderDealImagery creater in CabWedRent)
        {
            creater.RarerPlainMorally(c);
        }
    }
    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void RarerAnyWedMorally()
    {
        foreach (HolderDealImagery creater in CabWedRent)
        {
            creater.RarerAnyMorally();
        }
    }
    /// <summary>
    /// fever ��ʼ�Զ�����
    /// </summary>
    public void RarerPlainPeruPaceName()
    {
        StartCoroutine(nameof(RimePaceNameLampUser));
    }
    /// <summary>
    /// fever �����Զ�����
    /// </summary>
    public void RarerAnyPeruPaceName()
    {
        StopCoroutine(nameof(RimePaceNameLampUser));
    }
    /// <summary>
    /// fever �Զ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator RimePaceNameLampUser()
    {
        while (PeriodScratch.Instance.GoCaneCraft)
        {
            if (VacantSkin.AtTract())
            {
                PaceDeal(Random.Range(-SkullStark / 2, SkullStark / 2));
                PaceDeal(Random.Range(-SkullStark / 2, SkullStark / 2));
                PaceDeal(Random.Range(-SkullStark / 2, SkullStark / 2));
            }
            else
            {
                WoldName(Random.Range(-SkullStark / 2, SkullStark / 2));
            }
            yield return new WaitForSeconds(0.3f);
        }

    }

    /// <summary>
    /// һ��������������
    /// </summary>
    /// <param name="count"></param>
    public void VaporKierDeal(int count)
    {
        foreach (HolderDealImagery creater in CabWedRent)
        {
            creater.WoldVeinDeal(count);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SoilLoud.NoseLoudScratch(SoilEither, SoilLoud.transform, 50, "Ball");
        if (VacantSkin.AtTract())
        {
            SoilPress.gameObject.SetActive(false);

        }
        else
        {
            SoilPress.gameObject.SetActive(true);
        }
    }
    float LeoDebtorDoctor()
    {
        return Random.Range(0, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Application.platform == RuntimePlatform.Android ||
                        Application.platform == RuntimePlatform.IPhonePlayer)
            {
                int fingerId = Input.GetTouch(0).fingerId;
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(fingerId))
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            ////����ƽ̨
            else
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            if (!SkateClue)
            {
                if (VacantSkin.AtTract())
                {
                    if (!NicheNameScratch.Instance.PaceDealSitTract()) return;
                    float coin_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (SkullStark / 2);
                    PaceDeal(coin_x);
                }
                else
                {
                    // �Ƿ���С��
                    if (!NicheNameScratch.Instance.PaceName()) return;
                    SkateClue = true;
                    StartCoroutine(nameof(SkateUpsideLampUser));
                    float drop_x = 0;
                    drop_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (SkullStark / 2);
                    AutoTineScratch.YouGet("DropBallCount", AutoTineScratch.BuyGet("DropBallCount") + 1);
                    WoldName(drop_x);
                }
            }

        }
    }
}
