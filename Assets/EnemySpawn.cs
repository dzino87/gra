using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float speed = 1f;
    public float bulletTime = 1f;
    public float bulletSpeed = 1f;
    public Text score;
    public Text endscore;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        Rigidbody2D instance = Instantiate(enemy, transform);
        instance.velocity = Vector2.left * speed;

        var counter = instance.GetComponent<PointCounter>();
        counter.pointText = score;
        counter.endText = endscore;

        var enemySc = instance.GetComponent<sc>();
        enemySc.shotTime = bulletTime;
        enemySc.bulletSpeed = bulletSpeed;
    }

    public void Restart1()
    {
        PointCounter.points = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
