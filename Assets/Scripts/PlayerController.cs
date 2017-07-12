using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public CharacterController cc;
	public float moveSpeed;


	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		moveSpeed = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {

		float hori = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");

		cc.Move(new Vector3(hori, 0f, vert) * moveSpeed + Physics.gravity * 0.01f);

		
		
	}
}
