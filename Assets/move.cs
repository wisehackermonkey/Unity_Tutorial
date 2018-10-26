using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	//movement speed of character
	public float speed = 10f;

	void Start () {
	}

	void Update () {
		//MOVE character left and right 
		//"d" key do action
				if(Input.GetKey("d")){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if(Input.GetKey("a")){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}
}
