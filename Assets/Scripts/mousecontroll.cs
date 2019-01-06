using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class mousecontroll : MonoBehaviour {
    public GameObject charakter;
    public Camera cam;
    private bool facingRight = false;
    private Rigidbody2D rgb;
    private float velX, velY;
    private Vector2 velocity;
    public float sensibility = 1f;
    private Vector3 position, rgbp;
    private bool isPosition = false;
    private bool isInside = false;
    private bool grabbed = false;
    private float xPositon, deltaXPosition;
    public float minVelocity;

    

    // Use this for initialization
    void Start () {
        rgb = GetComponent<Rigidbody2D>();
       
        if (cam == null) {
            cam = Camera.main;
        }
	}

    // Update is called once per frame
    private void Update()
    {
        isInside = false;
        if ((rgbp.x - 0.5 < position.x) && (rgbp.x + 0.5 > position.x) && (rgbp.y - 0.5 < position.y) && (rgbp.y + 0.5 > position.y))
        {
            isInside = true;
        }

        if ((isInside && Input.GetMouseButtonDown(0)))
        {
            grabbed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            grabbed = false;
        }
        if (Input.GetMouseButtonUp(0) && grabbed)
        {
            rgb.velocity = velocity;
            grabbed = false;

            //isInside = false;
        }

    }
    void FixedUpdate () {
        xPositon = rgb.position.x;
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rgbp = rgb.position;
       

       
       
        HandleMouseEvents();
       
       
        Debug.Log(grabbed);
	}
    void HandleMouseEvents()
    {
        

        if (grabbed == true)
        {
            velX = Input.GetAxis("Mouse X") / Time.fixedDeltaTime;
            velY = Input.GetAxis("Mouse Y") / Time.fixedDeltaTime;
            velocity = new Vector2(velX * sensibility, velY * sensibility);

            Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 targetPosition = new Vector3(rawPosition.x, rawPosition.y);
            rgb.MovePosition(targetPosition);
            rgb.velocity = velocity; 
        }
        
        

        if (Math.Abs(rgb.velocity.x) > minVelocity)
        {
            if (rgb.velocity.x < 0 && !facingRight)
            {
                Flip();
            }
            else if (rgb.velocity.x > 0 && facingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void setSensibility(float newSensibility)
    {
        sensibility = newSensibility;
    }

}
