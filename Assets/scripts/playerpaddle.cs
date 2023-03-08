using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpaddle : paddle
{

    void FixedUpdate(){

        if(Input.GetAxisRaw("Vertical") > 0){

            rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);

        }else if(Input.GetAxisRaw("Vertical") < 0){
            rb.MovePosition(rb.position + Vector2.down * speed * Time.fixedDeltaTime);
        }else{
            rb.velocity = Vector2.zero;
        }
        


    }




}
