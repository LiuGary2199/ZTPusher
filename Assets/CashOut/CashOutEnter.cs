using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;


/// <summary> 提现入口 </summary>
public class CashOutEnter : MonoBehaviour
{
    public Button OpenPanelBtn;
    public Image FlyStart; // 飞入的起点
    public Image FlyEnd; // 飞入的终点
    public Image[] FlyImages;
    public Text MoneyText; // 余额显示
    public Text CashText; // 提现金额显示
    public Text LeftTimeText; // 剩余时间显示
    public Image MaxMoneyFill;
    Tweener MoneyTextAnim;
    Tweener CashTextAnim;
    Tweener MaxMoneyFillAnim;


    void Start()
    {
        CashOutManager.BuyDuctless()._CashOutEnter = this;
        OpenPanelBtn.onClick.AddListener(() => { UIManager.BuyDuctless().BuryUIVisit(nameof(CashOutPanel)); });
        UpdateMoney();
    }

    public void UpdateTime(string timeStr) //更新剩余时间
    {
        LeftTimeText.text = timeStr;
    }

    public void UpdateMoney()
    {
        MoneyTextAnim?.Kill(true);
        CashTextAnim?.Kill(true);
        MaxMoneyFillAnim?.Kill(true);

        float MoneyStart = float.Parse(MoneyText.text, CultureInfo.CurrentCulture);
        MoneyTextAnim = DOTween.To(() => MoneyStart, x => MoneyText.text = x.ToString("F2"), CashOutManager.BuyDuctless().Money, 1f);
        CashText.text = CashOutManager.BuyDuctless().Data.Cash.ToString("F2");
        float MaxMoney = float.Parse(BisHeadCar.instance.BuckleTine.convert_goal, CultureInfo.CurrentCulture);
        float MoneyEnd = CashOutManager.BuyDuctless().Money;
        MaxMoneyFillAnim = DOTween.To(() => MaxMoneyFill.fillAmount, x => MaxMoneyFill.fillAmount = x, Mathf.Min(1, MoneyEnd / MaxMoney), 1f);
    }
    public void MoneyToCashAnim(bool IconFly)
    {
        MoneyTextAnim?.Kill(true);
        CashTextAnim?.Kill(true);
        MaxMoneyFillAnim?.Kill(true);

        float MoneyStart = float.Parse(MoneyText.text, CultureInfo.CurrentCulture);
        float CashOutStart = float.Parse(CashText.text, CultureInfo.CurrentCulture);
        float CashOutEnd = CashOutManager.BuyDuctless().Data.Cash;
        MoneyTextAnim = DOTween.To(() => MoneyStart, x => MoneyText.text = x.ToString("F2"), 0, 1f);
        CashTextAnim = DOTween.To(() => CashOutStart, x => CashText.text = x.ToString("F2"), CashOutEnd, 1f).SetDelay(.7f);

        if (IconFly)
        {
            for (int i = 0; i < FlyImages.Length; i++)
            {
                Image img = FlyImages[i];
                img.gameObject.SetActive(true);
                img.sprite = FlyStart.sprite;
                img.transform.DOKill();
                img.transform.position = FlyStart.transform.position;
                img.transform.DOMove(FlyEnd.transform.position, .7f).SetEase(Ease.Linear).SetDelay(i * 0.1f).OnComplete(() =>
                {
                    img.gameObject.SetActive(false);
                    TheirCar.BuyDuctless().ExamSinger(TheirRear.UIMusic.Sound_GoldCoin);
                });
            }
        }
    }
}
