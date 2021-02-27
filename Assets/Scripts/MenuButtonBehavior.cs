using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonBehavior : MonoBehaviour
{


    GameObject audioplayer;
    private void Start() 
    {
        audioplayer = GameObject.FindGameObjectWithTag("AudioPlayer");

    }

    public void OnNewGamePressed()
    {
        PlayButtonSFX();
        SceneManager.LoadScene("GameScene");
    }



    public void OnQuitGamePressed()
    {
        PlayButtonSFX();
        print("QuitGame");
        Application.Quit();
    }



    public void OnRestartGamePressed()
    {
        PlayButtonSFX();
        SceneManager.LoadScene("GameScene");
    }


    public void OnMainMenuPressed()
    {
        PlayButtonSFX();
        SceneManager.LoadScene("Menu");
    }


    public void OnResumeButtonPressed()
    {
        PlayButtonSFX();
        GameObject.FindGameObjectWithTag("PauseMenu").SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Movement_newinput>().paused = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Camera_newinput>().SetCameraMove();
        Time.timeScale = 1;

    }


    void PlayButtonSFX()
    {
        audioplayer.GetComponent<AudioSource>().Play();
    
    }
}
