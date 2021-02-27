using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonBehavior : MonoBehaviour
{

    public void OnNewGamePressed()
    {
        SceneManager.LoadScene("GameScene");
    }



    public void OnQuitGamePressed()
    {
        print("QuitGame");
        Application.Quit();
    }
}
