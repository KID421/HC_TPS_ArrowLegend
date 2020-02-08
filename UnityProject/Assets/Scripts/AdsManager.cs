using UnityEngine;
using UnityEngine.Advertisements;   // 引用 廣告 API

// C# 僅能繼承一個類別，可以實作多個介面(裝備)
public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    private string googleID = "3436899";            // Google 專案 ID
    private bool testMode = true;                   // 測試模式：允許在 Unity 內側試
    private string placemnetRevival = "revival";    // 廣告類型：復活
    private Player player;                          // 玩家腳本

    public static bool lookAd;                      // 靜態 布林值 是否看廣告

    private void Start()
    {
        Advertisement.AddListener(this);                // 廣告.添加監聽腳本(此腳本);
        Advertisement.Initialize(googleID, testMode);   // 廣告.初始化(ID，測試模式);
        player = FindObjectOfType<Player>();            // 透過類型尋找物件
    }

    /// <summary>
    /// 顯示廣告
    /// </summary>
    public void ShowAD()
    {
        if (Advertisement.IsReady(placemnetRevival))    // 如果 廣告.是否準備完成(廣告 ID)
        {
            lookAd = true;                              // 看廣告 = 是
            Advertisement.Show(placemnetRevival);       // 廣告.顯示(廣告 ID)
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
    }

    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    /// <summary>
    /// 廣告完成
    /// </summary>
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == placemnetRevival)    // 如果 玩家看的廣告 ID = 復活廣告 ID
        {
            switch (showResult)                 // switch 判斷式(廣告結果)
            {
                case ShowResult.Failed:         // 狀況 1 失敗：
                    print("廣告失敗");
                    break;
                case ShowResult.Skipped:        // 狀況 2 略過：
                    print("廣告略過");
                    break;
                case ShowResult.Finished:       // 狀況 3 失敗：
                    print("廣告成功");
                    lookAd = false;             // 看廣告 = 否
                    player.Revival();           // 玩家.復活
                    break;
            }
        }
    }
}
