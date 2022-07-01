using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    [Header("Physics")]
    // As you[The Reader] see I have made a instance of Rigidbody.
    public Rigidbody rb;

    [Header("Values")]
    [SerializeField]float Speed = 2f;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();        
    }

    private void Move()
    {
        /* Made a local value in line 24 & line 25 / To know about "input" go through the documentation "Scripting API" part & these axis is are present in edit > project settings > Input Maneger .
         */
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");


        //rb.velocity = Vector3.zero;
        rb.velocity = new Vector3(xMov * Speed, 0, zMov * Speed).normalized;
    }
}
