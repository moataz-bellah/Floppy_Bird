using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float movementForce = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void FixedUpdate()
    {
        player.AddForce(new Vector2(movementForce, 0f));
    }
}
