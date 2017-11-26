﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestArea:MonoBehaviour
{
	public GameObject questButton;

	void Awake()
	{
		questButton.SetActive(false);
	}

	void Start()
	{}
	
	// Update is called once per frame
	void Update () 
	{
		if(Utils._DistanceDetection(this.gameObject, GameObject.FindObjectOfType<PlayerMovement>().gameObject) < 2) 
		{
			questButton.SetActive (true);
		}else{
			questButton.SetActive (false);
		}
	}
}