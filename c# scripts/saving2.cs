using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
 
public class saving2 : MonoBehaviour
{
    
    public float x,y,z;
    public Animator anim;
    public GameObject player;
    
 
    public void SaveGame()
    {
        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        print("Game saved!");
        SaveCords();
    }

    public void SaveCords()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
        print("saved cords!");
    }
 
    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        print("Game loaded!");
    }
    public void loadcords()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x,y,z);
        transform.position = LoadPosition;
    }
    public void load()
    {
        LoadGame();

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            SaveCords();
            Application.LoadLevel("evil");
        }
    }
}
