using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject charakter;
    private Vector3 cameraPosition;
	// Use this for initialization
	void Start () {
        cameraPosition = transform.position - charakter.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = charakter.transform.position + cameraPosition;
		
	}
}
