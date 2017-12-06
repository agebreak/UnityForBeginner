using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FBGameManager : MonoBehaviour {
    public GameObject cactus;
    public float spawnTime = 1;
    public float minY = -1;
    public float maxY = 1;
    public bool gameOver = false;
    public AudioClip deathSound;
    public int score = 0;
    public Text textScore;

    public static FBGameManager instance;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateCactus", 0, spawnTime);

        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateCactus()
    {
        if (FBGameManager.instance.gameOver == true)
            return;

        // 랜덤하게 y값을 결정한다
        Vector3 orgPos = cactus.transform.position;
        float rndY = Random.Range(minY, maxY);
        orgPos.y += rndY;

        // 선인장을 생성합니다 
        Instantiate(cactus, orgPos, Quaternion.identity);
    }

    public void GameOver()
    {
        if (gameOver == true)
            return;

        gameOver = true;

        AudioSource.PlayClipAtPoint(deathSound, Vector3.zero);
    }

    public void AddScore()
    {
        ++score;        
        textScore.text = score.ToString();
    }
}
