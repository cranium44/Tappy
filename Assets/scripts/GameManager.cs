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

    //activate or deactivate screens based on the state
    void SetPageState(PageState state)
    {
        switch (state)
        {
            case PageState.None:
                startScreen.SetActive(false);
                gameOverScreen.SetActive(false);
                countdownScreen.SetActive(false);
                break;

            case PageState.Start:
                startScreen.SetActive(true);
                gameOverScreen.SetActive(false);
                countdownScreen.SetActive(false);
                break;

            case PageState.GameOver:
                startScreen.SetActive(false);
                gameOverScreen.SetActive(true);
                countdownScreen.SetActive(false);
                break;

            case PageState.CountDown:
                startScreen.SetActive(false);
                gameOverScreen.SetActive(false);
                countdownScreen.SetActive(true);
                break;
        }
    }

    //methods that will be called when buttons on ui are pressed

    public void GameOverConfirmed()
    {
        //called when replay button is pressed
        OnGameOverConfirmed();
        SetPageState(PageState.Start);
    }

    public void StartGame()
    {
        //called when play button is pressed
        SetPageState(PageState.CountDown);
        
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
