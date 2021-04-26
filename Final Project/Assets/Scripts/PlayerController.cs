using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject moneyPrefab;

    public bool isSlowEnough = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
