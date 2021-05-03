using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject moneyPrefab;
    public bool isSlowEnough = true;
    void Update()
    {
        //When player left clicks, they spawn money
        if (Input.GetKeyDown(KeyCode.Mouse0) && isSlowEnough)
            {
                Instantiate(moneyPrefab, transform.position, moneyPrefab.transform.rotation);
                isSlowEnough = true;
            }
    }


}
