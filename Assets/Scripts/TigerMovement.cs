﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerMovement : MonoBehaviour 
{
	public Transform animalStopPoint;
	public Transform fadeInOutPoint;

	private UnityEngine.AI.NavMeshAgent nav;

	private void Start() {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
		FadeInOutStatus.fadeInOutStatus = true;
	}

	private void Update() {
		Debug.Log("Status : " + FadeInOutStatus.fadeInOutStatus);

		if(FadeInOutStatus.fadeInOutStatus == true)
		{
			nav.SetDestination(animalStopPoint.position);
		}

		else
		{
			nav.SetDestination(fadeInOutPoint.position);

			if ((transform.position - fadeInOutPoint.position).magnitude < 2f)
			{
				Destroy(gameObject);
			}
			//Vector3.Distance();
				
		}
	}
}