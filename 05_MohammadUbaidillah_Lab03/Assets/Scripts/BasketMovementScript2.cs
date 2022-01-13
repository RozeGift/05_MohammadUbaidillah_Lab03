using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript2 : MonoBehaviour
{
    public float speed;
    public float maxXlimit = 7f;

    public int score;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        scoreText.text = "Score: " + score;
        BasketLimitChecker();

        if(score == 30)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    void BasketLimitChecker()
    {
        // Limit the basket's movements //

        if (transform.position.x > maxXlimit)
        {
            transform.position = new Vector3(maxXlimit, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -maxXlimit)
        {
            transform.position = new Vector3(-maxXlimit, transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Healthy")
        {
            score += 10;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Unhealthy")
        {
            SceneManager.LoadScene("LoseScene");
        }

    }





}
