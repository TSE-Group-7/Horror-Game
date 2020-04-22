using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarPlayerMovement : MonoBehaviour
{
    public Animator animator;

    public float speed = 5f;

    void Update()
    {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * speed * Time.deltaTime;
        transform.position += movement;

    }
}
