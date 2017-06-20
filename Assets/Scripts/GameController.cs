using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameController : MonoBehaviour {
    
    public GUIText scoreText;
	
	private bool gameOver;
	private bool restart;
	private int score;

    void Start () {
        gameOver = false;
		restart = false;
        score = 0;
        UpdateScore ();
	}
    
    void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			AddScore(10);
            GetComponent<AudioSource>().Play ();
		}
	}

    public void AddScore (int newScoreValue) {
        score += newScoreValue;
        UpdateScore ();
    }
    
    void UpdateScore () {
        scoreText.text = "Score: " + score;
    }
    
    public void Save(){
    }
    
    public void Load() {
    }
    
    public void GameOver ()
	{
//		gameOverText.text = "Game Over!";
		gameOver = true;
	}
}
