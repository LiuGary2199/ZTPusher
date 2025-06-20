using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Random = UnityEngine.Random;

public class WebDecode : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("boxImg")]    public GameObject FoxRay;
[UnityEngine.Serialization.FormerlySerializedAs("boxBtn")]    public Button FoxOak;
[UnityEngine.Serialization.FormerlySerializedAs("bubbleGifImage")]    public GameObject BronzeLotParis;
    private Sequence _Own1;
    private Sequence _Own2;


    void Start()
    {
        WebJeanHopper();

        FoxOak.onClick.AddListener(() =>
        {
            WarHopper();
            WebWedPassageway.Instance.BuryPronePress();
        });
    }


    public void WebBulge()
    {
        YouOakPerfume();
        transform.DOPause();
        _Own1.Pause();
        _Own2.Pause();
    }

    public void WebMaraca()
    {
        YouOakRadius();
        transform.DOPlay();
        _Own1.Play();
        _Own2.Play();
    }

    public void YouOakRadius()
    {
        FoxOak.enabled = true;
    }

    public void YouOakPerfume()
    {
        FoxOak.enabled = false;
    }

    private void WarHopper()
    {
        FoxRay.SetActive(false);
        FoxOak.gameObject.SetActive(false);
        BronzeLotParis.SetActive(true);
    }


    private void WebJeanHopper()
    {
        _Own1 = DOTween.Sequence();
        _Own2 = DOTween.Sequence();
        int leftOrRight = Random.Range(0, 2);
        if (leftOrRight == 0)
        {
            transform.localPosition = new Vector3(-450f, 0, 0);
            _Own1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Own1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Own1.SetLoops(-1);
            _Own1.Play();

            _Own2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Own2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Own2.SetLoops(-1);
            _Own2.Play();
            transform.DOLocalMoveX(450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Own1.Kill();
                _Own2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
        else
        {
            transform.localPosition = new Vector3(450, 0, 0);
            _Own1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Own1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Own1.SetLoops(-1);
            _Own1.Play();

            _Own2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Own2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Own2.SetLoops(-1);
            _Own2.Play();
            transform.DOLocalMoveX(-450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Own1.Kill();
                _Own2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
    }
}