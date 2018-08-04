using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {


    //properties
    public GameObject gameOverText; // holds the gameObject that contains the UI text with game Over Message
    public Text scoreText; //holds the Text UI with the score 
    public static gameController gameControllerInstance; // a instance from our gameController script to access statically

    //variables
    public bool gameOverFlag = true; //flag to gameOver
    private int scoreValue = 0;//store the value of the score of the players;
    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake () {
        //if has any instance of this script running receive this if not destory itself
        if (gameControllerInstance == null){
            gameControllerInstance = this;
        }else if (gameControllerInstance != this) {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (gameOverFlag && Input.GetKeyDown(KeyCode.UpArrow.ToString())){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
		
	}

    public void BirdScore()
    {
        if (gameOverFlag)
        {
            return;
        }
        scoreValue++;
        scoreText.text = "Score: " + scoreText.ToString();
    }
  
    public void BirdDied(){
        gameOverText.SetActive(true);
        gameOverFlag = true;
    }
}
