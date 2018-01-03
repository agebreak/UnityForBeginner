using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FBGameManager : MonoBehaviour {
    public GameObject cactus;
    public GameObject readyUI;
    public GameObject gameOverUI;
    public TextMesh scoreText;
    public TextMesh scoreBest;
    public float spawnTime = 1;
    public float minY = -1;
    public float maxY = 1;
    public bool gameOver = false;
    public bool ready = true;
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

        if (FBGameManager.instance.ready == true)
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

        gameOverUI.SetActive(true);
        Vector3 pos = gameOverUI.transform.position;
        pos.y -= 5;

        iTween.MoveFrom(gameOverUI, pos, 1.0f);

        SetScoreBorad();

    }

    public void GameReady()
    {
        ready = false;
        //readyUI.SetActive(false);
        iTween.FadeTo(readyUI, 0, 0.5f);
    }

    public void AddScore()
    {
        ++score;        
        textScore.text = score.ToString();
    }

    // 게임오버 화면에서 스코어를 UI에 표시한다
    void SetScoreBorad()
    {
        scoreText.text = score.ToString();

        // 1. 데이터에 저장된 값을 가져온다. 
        int bestScore = PlayerPrefs.GetInt("SCORE");
        // 2. 현재 스코어하고 비교한다. 
        // 3. 비교해서 현재스코어가 크면, 현재 스코어를 베스트로 표시하고, 데이터에 저장한다. 
        if(score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("SCORE", bestScore);
        }
        // 4. 현재 스코어가 작으면 그냥 베스트에 저장된 값을 표시하고 끝낸다.

        scoreBest.text = bestScore.ToString();
    }
}
