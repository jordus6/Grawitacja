using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public float maxSpeed = 10;
    bool facingRight = true;
    private Rigidbody2D myRygidbody;
    Animator anim;
	// Use this for initialization
    
	void Start () {
        anim = GetComponent<Animator>();
        myRygidbody = GetComponent<Rigidbody2D>();
	}
    private void FixedUpdate()
    {
        Vector2 position = myRygidbody.position;
        Debug.Log(facingRight);
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        anim.SetFloat("Speed", Mathf.Abs(horizontal));

    }
    private void HandleMovement(float horizontal)
    {
        
        myRygidbody.velocity = new Vector2(horizontal * maxSpeed, myRygidbody.velocity.y);
      
        if (horizontal > 0 && !facingRight)
        {
            Flip();
        }
        else if (horizontal < 0 && facingRight)
        {
            Flip();
        }
      
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    // Update is called once per frame
    
}
