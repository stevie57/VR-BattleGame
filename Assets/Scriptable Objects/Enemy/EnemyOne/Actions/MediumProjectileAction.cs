﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/MediumProjectile")]
public class MediumProjectileAction : Action
{
    EnemyProjectileHandler enemyProjectileHandler;

    public override void Act(EnemyStateController controller)
    {
        CheckEnemyProjectileHandler(controller);
        SpawnBasicProjectiles(controller);
    }

    private void SpawnBasicProjectiles(EnemyStateController controller)
    {
        //if (enemyProjectileHandler.CheckProjectileHandlerState())
        //{
            enemyProjectileHandler.StartBasicProjectilesCoroutine(3, 2);
        //}
    }

    private void CheckEnemyProjectileHandler(EnemyStateController controller)
    {
        if (enemyProjectileHandler == null)
        {
            enemyProjectileHandler = controller.enemyProjectileHandler;
        }
    }
}
