using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    PlayerController player;

    [SerializeField]
    TextMeshProUGUI numberText;

    private void Update()
    {
        numberText.text = player.GetScore().ToString("N2") + " m";
        
    }
}
