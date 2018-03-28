﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

	// User Inputs
	private float degreesPerSecond = 7.0f;
	private float amplitude = 0.5f;
	private float frequency = 0.5f;

	// Position Storage Variables
	Vector3 posOffset = new Vector3 ();
	Vector3 tempPos = new Vector3 ();

	// Use this for initialization
	void Start () {
		posOffset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Spin object around Y-Axis
		transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * degreesPerSecond), Space.World);

		// Float up/down with a Sin()
		tempPos = posOffset;
		tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;

		transform.position = tempPos;
	}
}
