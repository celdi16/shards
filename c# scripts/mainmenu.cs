using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour{
    
    public float[] position;
    public int tpss;

    public void PlayGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        print("Game loaded!");
    }

    public void quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void SaveCords()
    {
        tpss = 0;
    }

    void start()
    {
        PlayerPrefs.SetInt("tpss", 0);
    }

}
