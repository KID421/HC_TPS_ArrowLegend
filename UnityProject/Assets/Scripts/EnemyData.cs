using UnityEngine;

// 建立素材選項(檔案名稱，選項名稱)
[CreateAssetMenu(fileName = "敵人資料", menuName = "KID/EnemyData")]
public class EnemyData : ScriptableObject   // 腳本化物件 將資料儲存於 Project
{
    [Header("血量"), Range(100, 3000)]
    public float hp = 100;
    [Header("血量最大值"), Range(100, 3000)]
    public float hpMax;
    [Header("攻擊力"), Range(1, 1000)]
    public float attack = 10;
    [Header("移動速度"), Range(0, 100)]
    public float speed = 1.5f;
    [Header("攻擊冷卻時間"), Range(1, 10)]
    public float cd = 3.5f;
    [Header("停止距離"), Range(1, 1000)]
    public float stopDistance = 1.5f;
    [Header("近戰攻擊距離"), Range(0, 10)]
    public float attackRange = 1.8f;
    [Header("攻擊延遲時間"), Range(0, 10)]
    public float attackDelay = 0.8f;
    [Header("遠攻離發射子彈位置位移"), Tooltip("X 不要調整，Y 調整高度，Z 調整前後")]
    public Vector3 attackOffset;
    [Header("遠攻子彈飛行速度"), Range(1, 2000)]
    public float bulletSpeed;
}