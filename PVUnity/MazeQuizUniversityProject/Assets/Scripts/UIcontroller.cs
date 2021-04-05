﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public GameObject player;
    public void OnCorrectAnswerClick(GameObject enemy)
    {
        Destroy(enemy);
        player.GetComponent<PlayerController>().enabled = true;
    }
    public void OnWrongAnswerClick(GameObject enemy)
    {
        enemy.GetComponent<Quiz>().Restart();
    }

    public void returnToMainMenu()
    {
        Application.LoadLevel(1);
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            returnToMainMenu();
        }
    }
}
