using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float speed = 1f;
    public Text text;
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
        instance.GetComponent<PointCounter>().pointText = text;
    }

    public void Restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
