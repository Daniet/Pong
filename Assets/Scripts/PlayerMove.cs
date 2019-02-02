using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log (Input.mousePosition);
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(-7f, Mathf.Clamp(mousePosition.y, -3.8f, 3.8f), transform.position.z);
	}
}
