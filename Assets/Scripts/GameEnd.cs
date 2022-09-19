using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEnd : MonoBehaviour
{

    private int defeatedEnemyCounter;
    private GameObject enemiesObject;
    private bool isGameEnd;
    [SerializeField] GameObject gameOverTextObject;
    [SerializeField] TMP_Text gameOverScoreText;
    [SerializeField] GameObject retryButtonObject;
    int enemiesCount;
    bool isPlayerDead;

    void Start()
    {
        isGameEnd = false;
        isPlayerDead = false;
        gameOverScoreText.enabled = false;
        enemiesObject = PlayerManager.instance.enemiesObject;
        defeatedEnemyCounter = 0;
        retryButtonObject.SetActive(false);
        gameOverTextObject.SetActive(false);
        enemiesCount = enemiesObject.transform.childCount;


    }

    void Update()
    {
        //Checking if Game Finished
        isGameEnd = (defeatedEnemyCounter ==  enemiesCount || TimerScript.instance.timeLeft <= 0 || isPlayerDead);

        if (isGameEnd)
        {
            print("GAME OVER");
            gameOverTextObject.SetActive(true);
            retryButtonObject.SetActive(true);
            gameOverScoreText.enabled = true;
            gameOverScoreText.text = "Score: " + ScoreScript.instance.score;
            defeatedEnemyCounter = 0;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Checking if my player dies
        if(collision.gameObject.name == "Player Sumo")
        {
            isPlayerDead = true;
            print("PLAYER DEAD!");
            return;
        }

        //Increase defeated enemies
        if (!isPlayerDead)
        {
            Destroy(collision.gameObject);
            defeatedEnemyCounter++;
            ScoreScript.instance.isScoreIncrease = true;

        }

    }
}
