using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float shotTime = 1f;
    public float bulletSpeed = 2f;
    private static List<Rigidbody2D> bullets = new List<Rigidbody2D>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", 1.0f, shotTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shot()
    {
        Rigidbody2D instance = Instantiate(bullet, transform);
        instance.transform.parent = null;
        instance.velocity = Vector2.left * bulletSpeed;
        print("spawn bullet");
        bullets.Add(instance);
    }
}
