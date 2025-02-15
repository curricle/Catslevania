﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;
    public CollectibleManager collectibleManager;
    public bool isNewGame;
    public bool gameLost;
    public bool gameWon;
    public bool finalBossDefeated;
    public void Update()
    {
        CheckGameWinCondition();
    }
    public void NewGame()
    {
        finalBossDefeated = false;
        isNewGame = true;
    }
    public void CheckGameWinCondition()
    {
        if(playerController.isDead)
        {
            gameLost = true;
        }
        else if(collectibleManager.allCollectiblesCollected)
        {
            gameWon = true;
        }
    }

    
}
