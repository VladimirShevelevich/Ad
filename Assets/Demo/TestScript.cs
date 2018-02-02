using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QAds;

public class TestScript : MonoBehaviour {

    public void ShowBanner()
    {
        QuickAds.instance.ShowBanner();
    }

    public void RemoveBanner()
    {
        QuickAds.instance.RemoveBanner();
    }

    public void ShowInter()
    {
        QuickAds.instance.ShowInterstitialAd();
    }    

    public void ShowRewarded()
    {
        QuickAds.instance.ShowRewardedAd();
    }    



    public void GetReward()
    {
        Debug.Log("Get Reward!");
    }
}
