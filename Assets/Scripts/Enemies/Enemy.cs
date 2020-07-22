using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject camGameOver;
    public int health = 100;
    public GameObject deathEffect;
    public Slider healthbar;

    public void TakeDamage(int damage)
    {

        health -= damage;
        if (health<=0)
        {
            Die();
        }
        healthbar.value = health;
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(collision.gameObject);
            camGameOver.SetActive(true);
        }
    }

}
