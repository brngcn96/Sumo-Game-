using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public int score;
    public bool isScoreIncrease;
    [SerializeField] TMP_Text scoreText;

    public static ScoreScript instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        
    }

    
    void Update()
    {
        if (isScoreIncrease)
        {
            score++;
            scoreText.text = score.ToString();
            isScoreIncrease = false;
        }
    }
}
