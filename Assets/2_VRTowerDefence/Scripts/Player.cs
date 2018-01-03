using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject effect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            // 카메라 기준으로 Ray를 만든다(쏜다)
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hitInfo = new RaycastHit();

            if(Physics.Raycast(ray, out hitInfo))
            {
                // 맞은 위치에 이펙트를 생성한다. 
                Instantiate(effect, hitInfo.point, Quaternion.identity);
            }
        }
	}
}
