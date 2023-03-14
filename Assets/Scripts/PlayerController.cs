using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed;
    private Vector3 _dir;

    [SerializeField] private KeyCode _up;
    [SerializeField] private KeyCode _down;

    private void FixedUpdate(){
        if(GetInput(_up, _down)) { Move(_dir); }
    }

    private bool GetInput(KeyCode up, KeyCode down){

        if(Input.GetKey(up)) {_dir = Vector3.up; }
        else if(Input.GetKey(down)) { _dir = Vector3.down; }
        else{ return false; }

        return true;
    }

    public void Move(Vector3 dir){

        transform.position += dir * Time.fixedDeltaTime * _speed;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.1f, 4.1f), transform.position.z);

    }

}
