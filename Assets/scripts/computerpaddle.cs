using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerpaddle : paddle
{
    
    public float compuetPaddleSpeed = 180f;

    public Rigidbody2D ballRb;

    void FixedUpdate(){

        if(ballRb.position.y > transform.position.y){

            rb.velocity = Vector2.up * compuetPaddleSpeed * Time.fixedDeltaTime;

        }else{

            rb.velocity = Vector2.down * compuetPaddleSpeed * Time.fixedDeltaTime;

        }


    }


    
}
