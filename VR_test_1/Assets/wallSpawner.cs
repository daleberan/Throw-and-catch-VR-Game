using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawner : MonoBehaviour
{
    public Rigidbody wall;
    public float speed = 10;
    public float Timer = 10;


    void SpitWall()
    {

        Rigidbody wallClone = (Rigidbody)Instantiate(wall, transform.position, transform.rotation);
        wallClone.velocity = transform.right * speed;


    }


    void Update()
    {


        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            SpitWall();
            Timer = 5f;

        }
    }

}
