using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject playerPos;
    public GameObject centreEye;
    public float speed = 1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerPos.transform.position += centreEye.transform.forward * Time.deltaTime * speed;
    }

}
