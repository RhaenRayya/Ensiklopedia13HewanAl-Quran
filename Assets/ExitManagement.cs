using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManagement : MonoBehaviour
{
   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0) // Main Menu
                Application.Quit();
            else
                SceneManager.LoadScene(0);
        }
    }
}
