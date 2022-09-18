using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEnd : MonoBehaviour
{

    private int counter = 0;
    private GameObject enemiesObject;
    private bool isGameEnd = false;
    [SerializeField] GameObject gameOverTextObject;
    [SerializeField] GameObject retryButtonObject;
    
    // Start is called before the first frame update
    void Start()
    {
        enemiesObject = PlayerManager.instance.enemiesObject;
        
        retryButtonObject.SetActive(false);
        gameOverTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        isGameEnd = counter == enemiesObject.transform.childCount || TimerScript.timeLeft <= 0;

        if (isGameEnd)
        {
            print("GAME OVER");
            gameOverTextObject.SetActive(true);
            retryButtonObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        counter++;
        
        
    }
}
