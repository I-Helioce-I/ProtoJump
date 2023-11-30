using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    Camera camera;


    public List<PlayerController> playerInGame = new List<PlayerController>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        

    }

    internal void GameOverScreen()
    {
        UIManager.Instance.ShowGameOverScreen();
        Time.timeScale = 0f;
    
    }
}
