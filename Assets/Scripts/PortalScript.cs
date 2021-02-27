using UnityEngine;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        print(other.gameObject.name);
        if (other.gameObject.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene().name == "GameScene")
            {
                SceneManager.LoadScene("GameScene2");
            }
            else if(SceneManager.GetActiveScene().name == "GameScene2")
            {
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("GameOver");

            }
        }    
    }
}
