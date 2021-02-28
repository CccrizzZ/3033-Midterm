using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonBehavior : MonoBehaviour
{


    GameObject audioplayer;
    public FPS_Movement_newinput mref;

    private void Start() 
    {
        audioplayer = GameObject.FindGameObjectWithTag("AudioPlayer");

    }

    public void OnNewGamePressed()
    {
        PlayButtonSFX();
        Time.timeScale = 1;
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
        mref.Unpause();
        // Time.timeScale = 1;
        // GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Camera_newinput>().SetCameraMove();
        // GameObject.FindGameObjectWithTag("Player").GetComponent<FPS_Movement_newinput>().paused = false;
        // GameObject.FindGameObjectWithTag("PauseMenu").SetActive(false);

    }


    void PlayButtonSFX()
    {
        audioplayer.GetComponent<AudioSource>().Play();
    
    }
}
