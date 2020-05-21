using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public static ScoreManager instance;
    public Text scoretext;
    private ScoreDisplay display;
    private int highScore;
    public int score;

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        display = scoretext.GetComponent<ScoreDisplay>();
    }


    public void addScore(int scr)
    {
        if(display != null) display.score += scr;
        score += scr;
    }

    void setHighScore()
    {
        if (score > highScore)
            highScore = score;
    }
  
}
