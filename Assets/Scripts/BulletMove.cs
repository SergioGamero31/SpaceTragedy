using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public GameObject player;
    
    private Transform playerTrans;

    private Rigidbody2D bulletRB;

    public float bulletSpeed;
    public float bulletLife;

    public int damage = 40;

    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTrans = player.transform;
    }
    void Start()
    {
        if (playerTrans.localScale.x > 0)
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
        }
        else 
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
        }
    }

    void Update()
    {
        Destroy(gameObject, bulletLife);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
