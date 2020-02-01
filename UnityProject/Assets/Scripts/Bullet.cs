using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;    // 接收遠攻敵人的攻擊力
    public bool player;     // 判斷武器是誰擁有的，true 玩家，false 怪物

    private void OnTriggerEnter(Collider other)
    {
        if (!player)                                            // 如果子彈不是玩家的
        {
            if (other.tag == "Player")                          // 如果 碰到物件.標籤 為 "Player"
            {
                other.GetComponent<Player>().Hit(damage);       // 碰到物件.取得元件<Player>().受傷(攻擊力);
            }
        }
        if (player)                                             // 如果子彈是玩家的
        {
            if (other.tag == "Enemy")                           // 如果 標籤 為 "Enemy"
            {
                other.GetComponent<Enemy>().Hit(damage);       
            }
        }
    }
}
