using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float movementSpeed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("speed", Mathf.Abs(moverHorizontal));

        Vector2 direction = new Vector2(moverHorizontal * movementSpeed, 0);
        rigidbody2d.MovePosition((Vector2)transform.position + direction);
    }


}
