using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void Exit()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
