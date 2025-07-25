using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyManager : MonoBehaviour
{
    static FlappyManager flappyManager;
    [SerializeField] private string sceneToLoad = "MainScene";

    public static FlappyManager Instance
    {
        get { return flappyManager; }
    }

    private int currentScore = 0;

    private void Awake()
    {
        flappyManager = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReturnGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void AddScore(int score)
    {
        currentScore += score;

        Debug.Log("Score: " + currentScore);
    }
}
