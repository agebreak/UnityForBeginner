using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSpawner : MonoBehaviour {
    public GameObject drone;

	// Use this for initialization
	void Start () {
        StartCoroutine(CreateDrone());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CreateDrone()
    {
        while (true)
        {
            Instantiate(drone, transform.position, Quaternion.identity);

            float delay = Random.Range(1.0f, 3.0f);
            yield return new WaitForSeconds(delay);
        }
        
    }
}
