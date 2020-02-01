using UnityEngine;

[CreateAssetMenu(fileName = "玩家資料", menuName = "KID/玩家資料")]
public class PlayerData : ScriptableObject
{
    [Header("血量")]
    public float hp = 200;
    [Header("最大血量：不會改變")]
    public float hpMax = 200;
    [Header("攻擊冷卻"), Range(0, 3)]
    public float cd = 2.5f;
    [Header("發射速度"), Range(0, 3000)]
    public int bulletPower = 1000;
    [Header("攻擊力"), Range(0, 3000)]
    public float attack = 30;
}
