/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIPastCar : MonoBehaviour
{
    private static UIPastCar _Ductless= null;
    //ui根节点对象
    private GameObject _AxLatterFine= null;
    //ui脚本节点对象
    private Transform _TarUIUntwistTell= null;
    //顶层面板
    private GameObject _AxToPress;
    //遮罩面板
    private GameObject _AxPastPress;
    //ui摄像机
    private Camera _UITarget;
    //ui摄像机原始的层深
    private float _RestrainUITargetExtra;
    //获取实例
    public static UIPastCar BuyDuctless()
    {
        if (_Ductless == null)
        {
            _Ductless = new GameObject("_UIMaskMgr").AddComponent<UIPastCar>();
        }
        return _Ductless;
    }
    private void Awake()
    {
        _AxLatterFine = GameObject.FindGameObjectWithTag(HutCosmos.SYS_TAG_CANVAS);
        _TarUIUntwistTell = RoundUnfair.SwimLagUnifyTell(_AxLatterFine, HutCosmos.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        RoundUnfair.NorUnifyTellAnRattleTell(_TarUIUntwistTell, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _AxToPress = _AxLatterFine;
        _AxPastPress = RoundUnfair.SwimLagUnifyTell(_AxLatterFine, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UITarget = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UITarget != null)
        {
            //得到ui相机原始的层深
            _RestrainUITargetExtra = _UITarget.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void YouPastMemory(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _AxToPress.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _AxPastPress.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _AxPastPress.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _AxPastPress.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _AxPastPress.GetComponent<Image>().color = newColor2;
                NucleusCandidTribe.BuyDuctless().Salt(CBuckle.mg_MemoryGibe);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _AxPastPress.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _AxPastPress.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_AxPastPress.activeInHierarchy)
                {
                    _AxPastPress.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _AxPastPress.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UITarget != null)
        {
            _UITarget.depth = _UITarget.depth + 100;
        }
    }
    public void DatePastMemory()
    {
        if (UIManager.BuyDuctless().LampUIVisit.Count > 0 || UIManager.BuyDuctless().BuyEveningWishSpell().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_AxPastPress.GetComponent<Image>().color.r, _AxPastPress.GetComponent<Image>().color.g, _AxPastPress.GetComponent<Image>().color.b,0);
        _AxPastPress.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void LordlyPastMemory()
    {
        if (UIManager.BuyDuctless().LampUIVisit.Count > 0 || UIManager.BuyDuctless().BuyEveningWishSpell().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _AxToPress.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_AxPastPress.activeInHierarchy)
        {
            _AxPastPress.SetActive(false);
            NucleusCandidTribe.BuyDuctless().Salt(CBuckle.It_MemoryShaft);
        }
        //恢复当前ui摄像机的层深
        if (_UITarget != null)
        {
            _UITarget.depth = _RestrainUITargetExtra;
        }
    }
}
