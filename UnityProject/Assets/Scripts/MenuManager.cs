using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("玩家資料")]
    public PlayerData data;

    /// <summary>
    /// 載入關卡
    /// </summary>
    public void LoadLevel()
    {
        data.hp = data.hpMax;               // 進入關卡前將血量 = 血量最大值
        SceneManager.LoadScene("關卡1");
    }

    /// <summary>
    /// 購買血量 +500
    /// </summary>
    public void BuyHp_500()
    {
        data.hpMax += 500;          // 血量最大值遞增 500
        data.hp = data.hpMax;       // 血量 = 血量最大值
    }

    /// <summary>
    /// 購買攻擊 +50
    /// </summary>
    public void BuyAtk_50()
    {
        data.attack += 50;          // 攻擊力遞增 50
    }
}
