using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary>
    /// 是否過關
    /// </summary>
    public bool pass;
    [Header("道具音效")]
    public AudioClip sound;

    private Transform player;
    private AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        player = GameObject.Find("玩家").transform;

        HandleCollision();
    }

    private void Update()
    {
        GoToPlayer();
    }

    /// <summary>
    /// 管理碰撞
    /// </summary>
    private void HandleCollision()
    {
        Physics.IgnoreLayerCollision(10, 8);    // 忽略圖層碰撞(圖層1，圖層2)
        Physics.IgnoreLayerCollision(10, 9);
    }

    /// <summary>
    /// 前往玩家
    /// </summary>
    private void GoToPlayer()
    {
        if (pass)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, 0.7f * 20 * Time.deltaTime);
            
            if (Vector3.Distance(transform.position , player.position) < 2.3f)  // 如果 金幣與玩家距離 < 2.3
            {
                aud.PlayOneShot(sound, 0.3f);       // 播放音效
                Destroy(gameObject, 0.25f);          // 刪除(物件，延遲時間)
            }
        }
    }
}
