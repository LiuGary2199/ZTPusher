using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoseScratch : WhigSuccessor<ThoseScratch>
{
    public string Head;

    public void BuryThose(string info)
    {
        Head = info;
        UIManager.BuyDuctless().BuryUIVisit(nameof(Those));
    }
}
