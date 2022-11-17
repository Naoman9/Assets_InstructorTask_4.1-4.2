using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDetection : MonoBehaviour
{

    public DestroyGameObject destroyGameObject;

    public static int score = 0;

    public Material textureColor;

    public MeshRenderer collisionColor;

    // Start is called before the first frame update
    void Start()
    {
        destroyGameObject = GetComponent<DestroyGameObject>();
        collisionColor = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detection Enemy Collision and Increase Size
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy_1") || collision.gameObject.CompareTag("Enemy_2")
           || collision.gameObject.CompareTag("Enemy_3") || collision.gameObject.CompareTag("Enemy_4")
           && destroyGameObject.enemyDestroyed)
        {
            transform.localScale += new Vector3(1, 1, 1);

            collisionColor.material = textureColor;

            score = score + 1;

            Debug.Log(score);


        }
    }

  
}
