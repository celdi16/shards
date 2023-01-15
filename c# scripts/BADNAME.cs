using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class BADNAME : MonoBehaviour
{
    public GameObject player;

    void Start()
    { 
        player.GetComponent<Animator>().Play("idk2 0");
        player.GetComponent<playermoveputer>().enabled = false;
        player.GetComponent<playermoveputer>().enabled = true;
    }

   
}
