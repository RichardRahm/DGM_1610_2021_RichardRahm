﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed =30;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        // Finds and stores PlayerController Script for later access
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();  
    }

    // Update is called once per frame
    void Update()
    {

        if(playerControllerScript.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            

        }
    }
}
