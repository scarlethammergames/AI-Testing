﻿using UnityEngine;
using System.Collections;

public class Killer_Mover : AI_Mover {


	// Use this for initialization
	void Start () {

		this.Health = 100;
		//setting agent
		this.agent = GetComponent<NavMeshAgent> ();
		
		gameObject.renderer.material.color = Color.green;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		Debug.Log (this.interested);
		
		move ();
		
	}

	//oncollision with player balls lose health


}
