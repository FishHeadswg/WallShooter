/*
Author: Trevor Richardson
WallGenerator.cs
02-04-2015

	Spawns walls to be shot at every 7s.
	Walls are removed after 5s.
	
 */

using UnityEngine;
using System.Collections;

public class WallGenerator : MonoBehaviour {

	public GameObject wall;
	public float ticker;
	
	void Start () {
		ticker = 7f; // trigger first wall
	}

	void Update () {
		ticker += Time.deltaTime;
		// spawn a wall every 7s passed, destroy after 5s
		if (ticker >= 7f) {
			GameObject newWall = (GameObject)Instantiate(
				wall, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(2.5f, 7.5f)),
				wall.transform.rotation);
			Destroy(newWall, 5f);
			ticker = 0; // reset ticker
		}
	}
}
