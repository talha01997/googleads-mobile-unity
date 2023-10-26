using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Sample;
public class AdsManager : MonoBehaviour
{
    public static AdsManager instance;
    BannerViewController bannerAd;
    InterstitialAdController interstitialAd;
    RewardedAdController rewardedAd;

    [SerializeField] string bannerId, interstitialId, rewardedId;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        bannerAd = GetComponent<BannerViewController>();
        interstitialAd = GetComponent<InterstitialAdController>();
        rewardedAd = GetComponent<RewardedAdController>();
    }
    
}
