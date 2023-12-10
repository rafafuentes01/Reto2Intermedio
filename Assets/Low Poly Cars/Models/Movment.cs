using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
  
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Animator animator = GetComponent<Animator>();
        animator.SetFloat("Xmove", horizontalInput);
        animator.SetFloat("Ymove", verticalInput);
    }
}
