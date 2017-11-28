using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerMovement : MonoBehaviour 
{
	public Transform animalStopPoint;
	private UnityEngine.AI.NavMeshAgent nav;
	
	private void Start() {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	private void Update() {
		nav.SetDestination(animalStopPoint.position);
	}
}