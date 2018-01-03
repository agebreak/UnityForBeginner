using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Drone : MonoBehaviour {
    public Transform tower;

	// Use this for initialization
	void Start () {
        // "Tower"라는 이름의 오브젝트를 찾고, 그 트랜스폼을 넣어준다
        tower = GameObject.Find("Tower").transform;

        GetComponent<NavMeshAgent>().destination = tower.position;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
