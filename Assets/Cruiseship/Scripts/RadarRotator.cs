using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarRotator : MonoBehaviour {
    public float rotationSpeed = 10;
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(transform.up, rotationSpeed);
	}
}
