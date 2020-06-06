using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Fire : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnBullet()
    {
        Rigidbody2D instance = Instantiate(bullet, transform);
        instance.velocity = Vector2.right * speed;
        print("spawn bullet");
    }
}

