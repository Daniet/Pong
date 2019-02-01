using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalBehaviour : MonoBehaviour {

	public Transform paddle;
	bool gamesStarted;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!gamesStarted){
			float posDif = paddle.position.x - transform.position.x;
			transform.position =  new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
			if(Input.GetMouseButtonDown(0)){
				gamesStarted = true;
			}
		}else{

		}
	}
}
