﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float jumpForce = 200f;
	public float forwardSpeed = 2f;
	public GameObject cam;
	public bool dead = false;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (dead == false) {
			rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
			cam.transform.Translate (new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = Vector2.zero;
				rb.AddForce ((Vector2.up) * jumpForce);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
			dead = true;
	}
}
