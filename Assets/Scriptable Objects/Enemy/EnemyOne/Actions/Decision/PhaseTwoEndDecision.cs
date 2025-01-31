﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/PhaseTwoEndDecision")]
public class PhaseTwoEndDecision : Decision
{
    private EnemyCharacter _enemyCharacter;
    public override bool Decide(EnemyStateController controller)
    {
        bool healthCheck = EvaluateCurrentHealth(controller);
        return healthCheck;
    }

    private bool EvaluateCurrentHealth(EnemyStateController controller)
    {
        if(_enemyCharacter == null)
        {
            _enemyCharacter = controller._enemyCharacter;
        }

        var healthThreshold = _enemyCharacter.MaxHealth * 0.25;
        Debug.Log($"Enemycharacter health threshold is {healthThreshold}");
        if (_enemyCharacter.Health <= (healthThreshold))
            return true;
        else
            return false;
    }
}
