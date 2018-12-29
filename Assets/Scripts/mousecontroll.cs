﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecontroll : MonoBehaviour {
    public GameObject charakter;
    public Camera cam;
    private bool facingRight = false;
    private Rigidbody2D rgb;
    private float velX, velY;
    private Vector2 velocity;
    public float sensibility;
    private Vector3 position,rgbp;
    private bool isPosition = false;
    private bool isInside = false;
    private bool grabbed = false;
	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();

        if (cam == null) {
            cam = Camera.main;
        }
	}
    
    // Update is called once per frame
    void FixedUpdate () {
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rgbp = rgb.position;
        isInside = false;
        if ((rgbp.x - 0.5 < position.x) && (rgbp.x + 0.5 > position.x) && (rgbp.y - 0.5 < position.y) && (rgbp.y + 0.5 > position.y))
        {
            isInside = true;
        }

        if ((isInside == true && Input.GetMouseButtonDown(0) == true))
        {
            grabbed = true;
        }       

        HandleMouseEvents();
        Debug.Log(isInside);
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
        if (!grabbed){
            velocity = new Vector2(0, 0);
        }
        if (Input.GetMouseButtonUp(0) && grabbed)
        {
            rgb.velocity = velocity;
            grabbed = false;
            
            //isInside = false;
        }


        if (rgb.velocity.x < 0.00000000001 && !facingRight)
        {
            Flip();
        }
        else if (rgb.velocity.x > 0.0000000001 && facingRight)
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
