using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;

    public GameObject PauseMenu;
    public GameObject player;
    public GameObject Dance;
    public GameObject Dance2;
    public GameObject PauseButton;



    void start()
    {
        PauseMenu.SetActive(false);
        GameIsPaused = false;
    }

    void Update(){
    if (Input.GetKeyDown(KeyCode.Escape))
        if (GameIsPaused)
        {
            Resume();
        }else
        {
            pause();
        }
    }

    public void quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Resume()
    {
        PauseButton.SetActive(true);
        Dance2.SetActive(false);
        Dance.SetActive(true);
        player.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void pause()
    {
        PauseButton.SetActive(false);
        Dance2.SetActive(true);
        Dance.SetActive(false);
        player.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
