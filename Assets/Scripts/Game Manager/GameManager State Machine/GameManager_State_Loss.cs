﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager_State_Loss : GameManagerState
{
    public override void Start(GameManager_BS gameManager)
    {
    }
    public override void EnterState(GameManager_BS gameManager)
    {
        gameManager.UImanager.LoadLossMenuUI();
    }
    public override void Update(GameManager_BS gameManager)
    {
        
    }
}
