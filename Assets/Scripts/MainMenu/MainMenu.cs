using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LayOut");
    }
      public void Quit()
    {
        Application.Quit();
    }
}
