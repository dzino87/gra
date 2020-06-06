 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointText;
    private static int points = 0;

    // Start is called before the first frame update
    void Update()
    {
        pointText.text = "Score :" + points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("PointCounter->OnTriggerEnter2D");
        print(points);
        if (other.gameObject.tag == "bullet")
        {
            if (other.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                print("Bullet Colision");
                points += 1;
                Destroy(other.gameObject);
                Destroy(gameObject);
            }

        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
