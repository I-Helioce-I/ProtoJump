using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float score;
    [SerializeField]
    bool isDead;

    private void Update()
    {
        if (transform.position.y > score)
        {
            score = transform.position.y;

        }

    }

    public void Die()
    {
        isDead = true;
        Debug.Log("PlayerIsDEa");
    }

    public float GetScore()
    {
        return score;
    }
}
