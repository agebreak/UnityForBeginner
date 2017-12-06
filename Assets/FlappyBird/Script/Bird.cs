using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce;
    public AudioClip jumpSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FBGameManager.instance.gameOver == true)
            return;

        // 1. 버튼을 클릭할때 = 버튼이 눌렸으면
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().useGravity = true;

            // 2. 속도를 0으로 만든다
            GetComponent<Rigidbody>().velocity = Vector3.zero;


            // 3. 위로 힘을 한번 준다 
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);

            AudioSource.PlayClipAtPoint(jumpSound, Vector3.zero);
        }
    }

    // 오브젝트가 충돌되면 호출되는 함수
    public void OnCollisionEnter(Collision collision)
    {
        FBGameManager.instance.GameOver();
    }

    public void OnTriggerEnter(Collider other)
    {
        FBGameManager.instance.AddScore();
    }
}
