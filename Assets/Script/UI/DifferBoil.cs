using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class DifferBoil : ForkUIVisit
{
    public static DifferBoil Instance;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text BurrowAfar;

   
    public override void Display()
    {
        base.Display();
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
    }

    public void NoseTine(double num)
    {
        BurrowAfar.text = num.ToString();
    }
    public override void Hidding()
    {
        base.Hidding();
    }
}