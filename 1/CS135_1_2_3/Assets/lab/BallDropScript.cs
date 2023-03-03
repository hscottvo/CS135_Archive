using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test1");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        Rigidbody ball_body = ball.GetComponent<Rigidbody>();
        ball_body.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
