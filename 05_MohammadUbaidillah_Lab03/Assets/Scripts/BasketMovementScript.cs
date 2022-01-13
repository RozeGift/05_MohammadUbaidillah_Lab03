using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public float maxXlimit = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
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
            print("Healthy");
        }

        else if (collision.gameObject.tag == "Unhealthy")
        {
            print("Unhealthy");
        }

    }





}
