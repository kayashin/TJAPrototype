using UnityEngine;
using UnityEngine.SceneManagement;

public class SC1 : MonoBehaviour
{
   public void GoToScene(string sceneName)
   {
        SceneManager.LoadScene(sceneName);
   }

   public void QuitApp()
   {
        Application.Quit();
   }
}
