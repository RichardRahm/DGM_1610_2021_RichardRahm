using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject moneyPrefab;
    private Vector3 spawnPos = new Vector3(2,0,0);

    void SpawnMoney()
    {
        if(playerControllerScript.isSlowEnough == false)
        {
            Instantiate(moneyPrefab, spawnPos, moneyPrefab.transform.rotation);
        }
        //spawns the money prefab
    }
}