using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	public float speed = 0;
	// Use this for initialization
	void Start () {
		speed = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 exactPos = Camera.main.WorldToScreenPoint (transform.position);
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (exactPos.x > 0) {
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (exactPos.x < Screen.width) {
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			if (exactPos.y < Screen.height) {
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			if (exactPos.y > 0) {
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
		}
	}
}

