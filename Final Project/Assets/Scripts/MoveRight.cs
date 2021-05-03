using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed;
    //makes money move right
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
