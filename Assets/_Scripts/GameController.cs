using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private bool gameOver;
    private bool winGame;

    public GameObject gameOverText;
    public static GameController instance;
    public GameObject startGameText;
    public GameObject winGameText;
    
    private Stopwatch timer;
    private GameObject timText;
    public Text tim;

	void Awake () {
        if( instance == null ) {
            instance = this;
            startGameText.SetActive( true );
        } else if( instance != null ) {
            Destroy( gameObject );
        }
	}

    void Start() {
        timer = new Stopwatch();
        timer.Start(); 
    }

	void Update () {
        if( gameOver && Input.GetKeyDown( KeyCode.R ) ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
        if( winGame && Input.GetKeyDown( KeyCode.Space ) ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
        UpdateTime(); 
	}

    public void Kill() {
        timer.Stop();
        UpdateTime();
        startGameText.SetActive( false );
        gameOverText.SetActive( true );
        gameOver = true;
    }

    public void Win() {
        timer.Stop();
        UpdateTime();
        startGameText.SetActive( false );
        winGameText.SetActive( true );
        winGame = true;
    }

    void UpdateTime() {
        tim.text = "Time Elapsed: " + timer.Elapsed.Seconds.ToString() + "s.";
    }
}
