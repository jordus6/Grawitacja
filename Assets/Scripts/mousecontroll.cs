using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecontroll : MonoBehaviour {
    public Camera cam;
    private bool facingRight = false;
    private Rigidbody2D rgb;
    private float velX, velY;
    private Vector2 velocity;
    public float sensibility;
	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
       
        if (cam == null) {
            cam = Camera.main;
        }
	}
    
    // Update is called once per frame
    void FixedUpdate () {
        HandleMouseEvents();            
	}
    void HandleMouseEvents()
    {
        velX = Input.GetAxis("Mouse X") / Time.fixedDeltaTime;
        velY = Input.GetAxis("Mouse Y") / Time.fixedDeltaTime;
        velocity = new Vector2(velX / sensibility, velY / sensibility);
        
        if (Input.GetMouseButton(0))
        {
            Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 targetPosition = new Vector3(rawPosition.x, rawPosition.y);
            rgb.MovePosition(targetPosition);
            rgb.velocity = velocity;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            rgb.velocity = velocity;
        }

        if (rgb.velocity.x < 0 && !facingRight)
        {
            Flip();
        }
        else if (rgb.velocity.x > 0 && facingRight)
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
}
