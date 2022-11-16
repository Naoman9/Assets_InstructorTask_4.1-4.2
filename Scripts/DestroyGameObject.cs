using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    // Lower bound Y-Axis
    private float lowerRangeY = -4.0f;

    // Check enemy destruction
    public bool enemyDestroyed;

    public GameObject player;
    // Start is called before the first frame update
    public bool gameOver;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerRangeY)
        {
            Destroy(gameObject);
            enemyDestroyed = true;
        }
        else if(player.transform.position.y < lowerRangeY)
        {
            gameOver = true;
            Debug.Log("Game Over");
        }

    }
}
