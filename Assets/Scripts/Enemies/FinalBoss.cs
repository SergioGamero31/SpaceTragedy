using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FinalBoss : MonoBehaviour
{
    public int heatlh;
    public int damage;
    private float timeBtwDamage = 1.5f;

    public Animator redPanel;
    public Animator camAnim;

    public Slider healthBar;

    void Update()
    {
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }
        healthBar.value = heatlh;
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")
        {

        }
    }*/
}
