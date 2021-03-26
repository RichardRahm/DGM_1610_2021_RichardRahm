using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
   
    public bool isSlowEnough = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When player left clicks, the money will show on the left as a "projectile"
        if (Input.GetKeyDown(KeyCode.Mouse0) && isSlowEnough)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
    }


}
