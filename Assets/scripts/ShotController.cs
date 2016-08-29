using UnityEngine;
using System.Collections;

public class ShotController : MonoBehaviour {

	public float speed = 0;
	// Use this for initialization
	void Start () {
		speed = 4.0f;

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 10, 200* -Time.deltaTime);
		transform.position += Vector3.up * speed * Time.deltaTime;
		Vector3 exactPos = Camera.main.WorldToScreenPoint (transform.position);

	}
}
