using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    public float jumpForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 1. 버튼을 클릭할때 = 버튼이 눌렸으면
        if(Input.GetMouseButtonDown(0))
        {
            // 2. 속도를 0으로 만든다
            GetComponent<Rigidbody>().velocity = Vector3.zero;


            // 3. 위로 힘을 한번 준다 
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }




    }
}
