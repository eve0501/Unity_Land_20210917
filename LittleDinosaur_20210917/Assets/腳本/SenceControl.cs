using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceControl : MonoBehaviour
{
    public void LoadSence(string nameSence)
    {
        SceneManager.LoadScene(nameSence);
    }

    public void Quit()
    {
        Application.Quit(); //離開應用程式
        print("關閉遊戲");
    }
}
