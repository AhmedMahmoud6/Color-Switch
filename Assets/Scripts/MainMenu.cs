using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale= 1.0f;
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene("Levels");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
