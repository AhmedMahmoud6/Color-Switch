using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public GameObject DeathMenuUI;
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        cam.position = new Vector2 (cam.position.x,player.position.y);
        DeathMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
}
