using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGameOver : MonoBehaviour
{
    public GameObject camGameOver;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(collision.gameObject);

            camGameOver.SetActive(true);

        }
    }
}
