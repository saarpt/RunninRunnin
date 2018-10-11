﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

     public GameObject effect;
   

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           

            Instantiate(effect, transform.position, Quaternion.identity);
           // Debug.Log(other.GetComponent<Player>().health);
            other.GetComponent<Player>().health -= damage;         
             Destroy(gameObject);

    }
   }
}
