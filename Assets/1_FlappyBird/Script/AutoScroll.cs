using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour {
    // 프로퍼티 
    public float speed; // 속도

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (FBGameManager.instance.gameOver == true)
            return;

        // 메인텍스쳐의 오프셋을 가져와서 offset 변수에 넣는다.
        // a = b
        // a = a + 1
        // b = a
        Vector2 offset = GetComponent<MeshRenderer>().material.mainTextureOffset;
        offset.x = offset.x + speed * Time.deltaTime;
        GetComponent<MeshRenderer>().material.mainTextureOffset = offset;

	}
}
