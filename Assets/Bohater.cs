using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bohater : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 upPosition;
    private Rigidbody2D rb;
    public float thrust;
    public GameObject gameOverPanel;


    private Vector3 up = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        upPosition = transform.position + new Vector3(0, 3, 0);
        gameOverPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > startPosition.y)
        {
            rb.velocity += new Vector2(0, -2*thrust)*Time.deltaTime;
        }
        else if (transform.position.y < startPosition.y)
        {
            transform.position = startPosition;
            rb.velocity = new Vector2(0, 0);
        }
    }

    public void Jump()
    {
        if (transform.position.y == startPosition.y)
        {
            rb.velocity = transform.up * thrust;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameOverPanel.gameObject.SetActive(true);
        Destroy(gameObject);
    }

}
