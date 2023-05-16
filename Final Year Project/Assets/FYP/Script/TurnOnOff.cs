using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerRB;

    public void TurnOn()
    {

        //playerRB.useGravity = true;
       //playerRB.isKinematic = false;
        player.GetComponent<Movement>().enabled = true;
    }
    
    public void TurnOff()
    {
        //playerRB.useGravity = false;
        //playerRB.isKinematic = true;
        player.GetComponent<Movement>().enabled = false;
    }
}
