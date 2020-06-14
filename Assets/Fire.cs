using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Fire : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 1f;
    public float shotDelay = 1f;
    public int maxBullets = 7;
    private float timeFromLastShot = 1f;
    private int bulletNo = 0;

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
        timeFromLastShot += Time.deltaTime;
        if (timeFromLastShot > shotDelay && bulletNo < maxBullets)
        {
            Rigidbody2D instance = Instantiate(bullet, transform);
            instance.velocity = Vector2.right * speed;
            //print("spawn bullet");
            timeFromLastShot = 0;
            bulletNo++;
        }
        if(timeFromLastShot > shotDelay*4)
        {
            bulletNo = 0;
        }
    }
}

