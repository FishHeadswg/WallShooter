/*
Author: Trevor Richardson
Shooter.cs
02-04-2015

	Spawns balls to shoot using either space or left-click.
	Movement supports WASD(QE) and arrow keys.
	
 */

using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	public GameObject powerBall; // ball prefab to instantiate

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			// create new ball from prefab, apply forward force, and destroy after 2s
			GameObject newBall = (GameObject)Instantiate(powerBall, gameObject.transform.position, Quaternion.identity);
			newBall.rigidbody.AddForce(Vector3.forward * 10000);
			Destroy(newBall, 2f);
		}
		// movement keys
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.E)) {
			gameObject.transform.Translate(new Vector3(Time.deltaTime * 15f, 0, 0));
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.Q)) {
			gameObject.transform.Translate(new Vector3(Time.deltaTime * -15f, 0, 0));
		}
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			gameObject.transform.Translate(new Vector3(0, 0, Time.deltaTime * 15f));
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			gameObject.transform.Translate(new Vector3(0, 0, Time.deltaTime * -15f));
		}
	}
}