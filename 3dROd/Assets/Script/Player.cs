using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    private int HP;
    private  Rigidbody rb;


    
    void Start()
    {
        HP = 1;
        rb = GetComponent<Rigidbody>();

    }
private void OnMove(InputValue Input)
    {
        Vector3 dir = Input.Get<Vector3>();
        rb.velocity = dir * 5f;
    }

    




}
