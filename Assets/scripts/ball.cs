using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    private Rigidbody2D rb;
    private float x, y;

    public float multipleScale = 300f;

    void Awake(){

        rb = GetComponent<Rigidbody2D>();

    }

    void Start(){

        AddStartingForce();

    }

    void AddStartingForce(){

        if(Random.value < .5f){
            x = -1f;
        }else{
            x = 1f;
        }

        if(Random.value < .5f){
            y = Random.Range(-1f , -.5f);
        }else{
            y = Random.Range(.5f, 1f);
        }

        rb.AddForce(new Vector2(x,y) * multipleScale);


    }

    void Update(){

        if(transform.position.x >= 6.2f || transform.position.x <= -6.2f){
            SceneManager.LoadScene(0);
        }


    }

}
