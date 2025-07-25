using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyManager : MonoBehaviour
{
    static FlappyManager flappyManager;
    FlappyUIManager flappyUIManager;
    [SerializeField] private string sceneToLoad = "MainScene";


    public FlappyUIManager FlappyUIManager
    {
        get { return flappyUIManager; }
    }
    public static FlappyManager Instance
    {
        get { return flappyManager; }
    }

    private int currentScore = 0;

    private void Awake()
    {
        flappyManager = this;
        flappyUIManager = FindAnyObjectByType<FlappyUIManager>();
    }

    private void Start()
    {
        flappyUIManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        flappyUIManager.SetRestart();
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
        flappyUIManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }
}
