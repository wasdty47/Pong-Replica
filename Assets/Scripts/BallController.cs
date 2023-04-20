using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb2d;

    private Vector2 _dir;
    
    private void Start(){

        RestartBallPosition();

    }

    private void RandomizeDirection(){

        float randY = Random.Range(-1f, 1f);
        float randX = Random.Range(-1f, 1f);

        _dir = new Vector2(randX, randY).normalized;

    }

    public void RestartBallPosition(){

        this.transform.position = new Vector3(0f, 0f, 0f);

        RandomizeDirection();
        _rb2d.velocity = Vector2.zero;
        _rb2d.AddForce(_dir * _speed);
    
    }

    private void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.tag == "Player"){

            float halfOfPlayer = col.gameObject.transform.localScale.y/2;
            float diffFromCenter =  transform.position.y - col.gameObject.transform.position.y;

            float newDirY = diffFromCenter/halfOfPlayer;

            _dir = new Vector2(-_dir.x, newDirY).normalized;
            _rb2d.velocity = Vector2.zero;
            _rb2d.AddForce(_dir * _speed);

        }

    }

}
