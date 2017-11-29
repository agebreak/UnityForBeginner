using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBGameManager : MonoBehaviour {
    public GameObject cactus;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateCactus", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateCactus()
    {
        Instantiate(cactus);
    }
}
