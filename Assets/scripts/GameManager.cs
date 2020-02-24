using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //game events that will be needed by other scripts
    public delegate void GameDelegate();
    public static event GameDelegate OnGameStarted;
    public static event GameDelegate OnGameOverConfirmed;


    //screens
    public GameObject startScreen;
    public GameObject countdownScreen;
    public GameObject gameOverScreen;

    //score text
    public Text scoreText;

    //create a singleton instance of gamemanager
    public static GameManager Instance;

    //page states
    enum PageState
    {
        None,
        Start,
        GameOver,
        CountDown
    }

    //game over state
    bool gameOver = false;
    int score = 0;

    //return game over state
    public bool GameOver { get { return gameOver; } }

    //instantiate the singleton reference as game is started
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
