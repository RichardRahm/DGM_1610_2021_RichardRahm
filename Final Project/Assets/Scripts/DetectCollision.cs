using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private Rigidbody rb;

    private GameManager gameManager;

    public GameObject moneyPrefab;

    public int moneyValue;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        
    }

    
    
    
}
