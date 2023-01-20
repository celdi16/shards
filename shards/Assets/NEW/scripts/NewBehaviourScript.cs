using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static bool GameIsPaused;

    public GameObject Grid2;
    public GameObject Grid1;
    public GameObject normal;
    public GameObject bad;
    public int game2;
    public int game1;


    void sart(){
        game2 = 0;
        game2 = PlayerPrefs.GetInt("game2");
        game1 = 0;
        game1 = PlayerPrefs.GetInt("game1");
        if (game1 is 0)
        {
            Grid1.SetActive(true);
            Grid2.SetActive(false );
        }
    }

    public void Resume()
    {
        Grid2.SetActive(false);
        Grid1.SetActive(true);
        bad.SetActive(false);
        normal.SetActive(true);
    }

    public void pause()
    {
        Grid2.SetActive(true);
        Grid1.SetActive(false);
        bad.SetActive(true);
        normal.SetActive(false);
    }
}