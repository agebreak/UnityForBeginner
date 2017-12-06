using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour {
    // 이동할 속도 
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (FBGameManager.instance.gameOver == true)
            return;

        // 위치를 speed 만큼 -x 방향으로 이동해준다. 
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        // 만약에 x 가 - 10 보다 작아지면 없앤다. 
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
	}
}
