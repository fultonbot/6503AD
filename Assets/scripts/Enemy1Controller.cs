﻿using UnityEngine;
using System.Collections;

public class Enemy1Controller : MonoBehaviour {
	public float speed = 0;
	// Use this for initialization
	void Start () {
		speed = 1.5f;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, 100*Time.deltaTime);
		transform.position += Vector3.down * speed * Time.deltaTime;
		Vector3 exactPos = Camera.main.WorldToScreenPoint (transform.position);
		Debug.Log(exactPos.x + "," + exactPos.y + "\n");




	}
}
