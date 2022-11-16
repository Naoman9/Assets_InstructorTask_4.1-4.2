using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody enemyRb;
    public GameObject player, enemy_1, enemy_2, enemy_3, enemy_4;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 lookDirection = (enemy_1.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
        else if (other.gameObject.CompareTag("Enemy_1"))
        {
            Vector3 lookDirection = (enemy_1.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }

        else if (other.gameObject.CompareTag("Enemy_2"))
        {
            Vector3 lookDirection = (enemy_2.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
        else if (other.gameObject.CompareTag("Enemy_3"))
        {
            Vector3 lookDirection = (enemy_3.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
        else if (other.gameObject.CompareTag("Enemy_4"))
        {
            Vector3 lookDirection = (enemy_4.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
    }
}
