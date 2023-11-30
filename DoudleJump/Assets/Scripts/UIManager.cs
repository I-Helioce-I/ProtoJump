using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    PlayerController player;

    [SerializeField]
    TextMeshProUGUI numberText;

    [SerializeField]
    TextMeshProUGUI gameOver;

    internal void ShowGameOverScreen()
    {
        gameOver.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        numberText.text = player.GetScore().ToString("N2") + " m";
        
    }


}
