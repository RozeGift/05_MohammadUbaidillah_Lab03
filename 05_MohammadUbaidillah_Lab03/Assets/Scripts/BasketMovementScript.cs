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

        if (transform.position.x > maxXlimit)
        {
            transform.position = new Vector3(maxXlimit, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -maxXlimit)
        {
            transform.position = new Vector3(-maxXlimit, transform.position.y, transform.position.z);
        }


    }



    

}
