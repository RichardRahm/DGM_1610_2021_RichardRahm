using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject moneyPrefab;
    private Vector3 spawnPos = new Vector3(2,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void SpawnMoney()
    {
        if(playerControllerScript.isSlowEnough == false)
        {
            Instantiate(moneyPrefab, spawnPos, moneyPrefab.transform.rotation);
        }
        
    }
}