﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShoot : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    void Update()
    {
        Debug.Log(Time.time);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            other.GetComponent<map1Move>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
    private void OnAnimatorMove()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}