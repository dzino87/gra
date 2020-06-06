using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colisionDetect : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameScore;
    public Text endScore;
    // Start is called before the first frame update

    private void Start()
    
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "box")
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(gameObject);

        }
    }
}
