using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Camera camera;

    public List<PlayerController> playerInGame = new List<PlayerController>();

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        

    }

}
