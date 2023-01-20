using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class imTrying : MonoBehaviour
{
    
    public GameObject player;
    public float ani;

    void Start()
    {

       ani =  PlayerPrefs.GetFloat("ani");

    if (ani is 0){
        player.GetComponent<Animator>().Play("idk");
    }
    PlayerPrefs.SetFloat("ani", 0);
    }

    
}
