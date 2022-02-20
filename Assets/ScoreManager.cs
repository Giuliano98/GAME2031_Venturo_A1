using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;

    public static ScoreManager Instance
    {
        get 
        { 
            if( _instance == null )
            {
                GameObject gameObject = new GameObject("ScoreManager");
                gameObject.AddComponent<ScoreManager>();
            }
            
            return _instance; 
        }
    }

    void Awake()
    {
        _instance = this;
    }



    public Text scoreText;
    int score = 0;

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + score.ToString();
    }
}
