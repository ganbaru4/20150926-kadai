﻿using UnityEngine;
using System.Collections;

public class shuuuuut : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * 3000 );
	}
	
	// Update is called once per frame
	void Update () {

	}
}
