using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp : MonoBehaviour
{

    public float x,y,z;
    public int tpss;


    private void Start(){

        
    tpss = PlayerPrefs.GetInt("tpss");
        loadcords();
        PlayerPrefs.SetInt("tpss", 1);
      print("?");
      }

    public void SaveCords()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        tpss = 0;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
        PlayerPrefs.SetInt("tpss", 1);
        print("saved cords!");
    }

    public void loadcords()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x,y,z);
        transform.position = LoadPosition;
    }

    public void sartcords()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        x = (-2.626f);
        y = (-0.904f);
        z = (-0f);
    }


}
