using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour {
    float x;
    float y;
    public float sensitive = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x += Input.GetAxis("Mouse X") * sensitive;
        y += Input.GetAxis("Mouse Y") * sensitive;
        y = Mathf.Clamp(y, -80, 80);

        transform.eulerAngles = new Vector3(-y, x, 0);
	}
}
