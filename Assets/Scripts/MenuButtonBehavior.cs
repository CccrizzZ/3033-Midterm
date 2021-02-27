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



    public void OnRestartGamePressed()
    {
        SceneManager.LoadScene("GameScene");
        
    }


    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene("Menu");

    }


    public void OnResumeButtonPressed()
    {
        GameObject.FindGameObjectWithTag("PauseMenu").SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Movement_newinput>().paused = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Camera_newinput>().SetCameraMove();
    }
}
