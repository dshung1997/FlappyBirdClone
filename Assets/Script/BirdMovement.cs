using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {

    // Use this for initialization
    private Animator _animator;
    private void Start()
    {
        _animator = transform.GetComponentInChildren<Animator>();
    }
    public float jumpVelocity;
    float g = -9.8f;

    public bool dead;
    void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.SetTrigger("Death");
        dead = true;
    }
    // Update is called once per frame
    void Update()
    {
        // x = x0 + v0 * t + a * t * t / 2
        transform.position += Vector3.up * (jumpVelocity * Time.deltaTime + g * Time.deltaTime * Time.deltaTime / 2);

        // vt = v0 + a * t
        jumpVelocity += g * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("DoFlap");
            jumpVelocity = 2.5f;
        }
        if (dead) return;
    }
}
