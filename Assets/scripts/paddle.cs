using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D rb;

    private void Awake(){

        rb = GetComponent<Rigidbody2D>();

    }





}
