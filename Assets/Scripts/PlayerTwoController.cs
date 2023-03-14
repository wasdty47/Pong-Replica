using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    
    [SerializeField] private GameObject _ball;
    [SerializeField] private float _speed;


    private void Update(){


        if(_ball.transform.position.y >transform.position.y){

            transform.position += new Vector3(0, _speed * Time.deltaTime, 0);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.1f, 4.1f), transform.position.z);

        }else{

            transform.position -= new Vector3(0, _speed * Time.deltaTime, 0);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.1f, 4.1f), transform.position.z);

        }
        

    }

}
