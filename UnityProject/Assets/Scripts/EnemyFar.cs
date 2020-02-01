using UnityEngine;
using System.Collections;   // 引用 系統.集合 API

public class EnemyFar : Enemy
{
    [Header("子彈物件")]
    public GameObject bullet;

    protected override void Attack()
    {
        base.Attack();
        StartCoroutine(CreateBullet());                                             // 啟動協程
    }
    
    /// <summary>
    /// 產生子彈
    /// </summary>
    private IEnumerator CreateBullet()
    {
        yield return new WaitForSeconds(data.attackDelay);                          // 等待
        Vector3 pos = new Vector3(0, data.attackOffset.y, 0);                       // 區域變數 座標 = 新 三維向量(0，位移.Y，0)

        // 座標：本身.座標 + 座標 + 前方 * 座標.Z
        GameObject tempBullet = Instantiate(bullet, transform.position + pos + transform.forward * data.attackOffset.z, Quaternion.identity);   // 實例化
        
        // 暫存子彈.取得元件<剛體>().增加推力(角色.前方 * 資料.子彈速度)
        tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * data.bulletSpeed);

        // 暫存子彈.添加元件<子彈>();
        tempBullet.AddComponent<Bullet>();
        // 暫存子彈.取得元件<子彈>().攻擊力 = 資料.攻擊力
        tempBullet.GetComponent<Bullet>().damage = data.attack;
        tempBullet.GetComponent<Bullet>().player = false;
    }
}
