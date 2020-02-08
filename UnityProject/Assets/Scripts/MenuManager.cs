using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// 載入關卡
    /// </summary>
    public void LoadLevel()
    {
        SceneManager.LoadScene("關卡1");
    }
}
