/*
Author: Trevor Richardson
Collide.cs
02-04-2015

	Simple collision detection script to re-color any cubes hit 
	directly by a ball.
	
 */

using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "PowerBall(Clone)")
		{
			this.renderer.material.color = Color.green;
		}
	}
}
