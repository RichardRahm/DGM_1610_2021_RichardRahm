using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        //destory object script is attached to
        Destroy(gameObject);
        //destroy other object hits a trigger
        Destroy(other.gameObject);
    }
}
