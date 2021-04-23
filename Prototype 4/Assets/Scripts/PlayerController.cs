﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private GameObject focalPoint;

    public bool hasPowerup;
    public float powerupStrength = 16.0f;

    public GameObject powerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

        // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime);

        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);
    }
    // allows player to pick up powerup and disappears on collision
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Debug.Log("Powerup Collected!");

            StartCoroutine(PowerupCountdownRoutine());

            powerupIndicator.gameObject.SetActive(true);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            //gets the enemies rigidbody copmonent so we can have acess to physics properties
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            //get the pos of enemy in reltion to player
            Vector3 awayFromplayer = (collision.gameObject.transform.position - transform.position);
            // report player collision
            Debug.Log("Player has collided with " + collision.gameObject + "with powerup set to" + hasPowerup);
            //oncollision kicks enemy back
            enemyRigidbody.AddForce(awayFromplayer * powerupStrength, ForceMode.Impulse);        
        }

    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7); hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}

