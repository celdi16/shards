using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class imTrying : MonoBehaviour
{
    
    public GameObject player;

    void Start()
    {
        player.GetComponent<Animator>().Play("idk");
    }

    
}
