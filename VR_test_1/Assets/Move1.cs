using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float speed =3;

    private Rigidbody rb;

    private float moveHorizontal;
    private float moveVertical;


    void Start()

    {

        rb = GetComponent<Rigidbody>();


    }


    void FixedUpdate()

    {


        moveHorizontal = 0;
        moveVertical = 0;

        moveHorizontal = Input.GetAxis("Horizontal");

        moveVertical = Input.GetAxis("Vertical");

        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);



        rb.AddForce(movement * speed);



    }
}
