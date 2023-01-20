using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    public float x,y,z;
    public float ani;

    [SerializeField] private string newGameLevel;

    public void newGameButton()
    {
        x = -2.772f;
        y = -3.27f;
        z = 0f;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);

        SceneManager.LoadScene(newGameLevel);
        PlayerPrefs.SetInt("tpss", 1);
        PlayerPrefs.SetInt("game1",1);
        PlayerPrefs.SetFloat("ani", 1);
    }

    public void LoadGameButton()
    {
        if(PlayerPrefs.HasKey("LevelSaved"))
        {
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
        }
    }

    public void LesDoIt()
    {
        PlayerPrefs.SetInt("tpss", 0);
        PlayerPrefs.SetInt("game1", 0);
        PlayerPrefs.SetFloat("ani", 1);
    }
}
