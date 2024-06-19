using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public float playerSpeed = 10f ;
 
    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f,0f).normalized;
        transform.Translate(moveDirection*playerSpeed*Time.deltaTime);
    }
}