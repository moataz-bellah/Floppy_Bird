using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public Rigidbody2D playerBody;
    public float movementForce = 20.5f;
     void FixedUpdate()
    {
        if(transform.position.x > 36f){
                FindObjectOfType<GameManager>().GameComplete();
                FindObjectOfType<GameManager>().GameOver();
        }
         else if(transform.position.y > 15f || transform.position.y < -11f){
                FindObjectOfType<GameManager>().GameOver();
            }
        else{
            transform.position += new Vector3(0.7f, 0, 0) * Time.deltaTime* movementForce;
        }
        
        //playerBody.AddForce(new Vector2(movementForce, 0f));
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 0.7f, 0) * Time.deltaTime * movementForce;
//            playerBody.AddForce(new Vector2(0f, 7f));
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -0.7f, 0) * Time.deltaTime * movementForce;
//            playerBody.AddForce(new Vector2(0f, -7f));
        }
    }
}
