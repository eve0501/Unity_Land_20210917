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
        Application.Quit(); //���}���ε{��
        print("�����C��");
    }
}
