using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject ScoreCanvas;
    public GameObject Player;
    //public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale =1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale =0;
        ScoreCanvas.SetActive(false);
        Player.SetActive(false);
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
        ScoreCanvas.SetActive(true);
        //Player.SetActive(true);
        FinalScore.finalScore=0;
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
