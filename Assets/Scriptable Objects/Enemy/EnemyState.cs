﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/EnemyState")]
public class EnemyState : ScriptableObject
{
    public Action[] EnterStateActions;
    public Action[] UpdateActions;
    public Transition[] Transitions;
    public List<BasicAttackData> BasicAttackDataList = new List<BasicAttackData>();
    public void EnterState(EnemyStateController controller)
    {
        DoEnterStateActions(controller);
    }
    private void DoEnterStateActions(EnemyStateController controller)
    {
        for (int i = 0; i < EnterStateActions.Length; i++)
        {
            EnterStateActions[i].Act(controller);
        }
    }

    public void UpdateStateActions(EnemyStateController controller)
    {
        DoUpdateActions(controller);
        CheckTransitions(controller);
    }

    private void DoUpdateActions(EnemyStateController controller)
    {
        for (int i = 0; i < UpdateActions.Length; i++)
        {
            UpdateActions[i].Act(controller);
        }
    }

    private void CheckTransitions(EnemyStateController controller)
    {
        for (int i = 0; i < Transitions.Length; i++)
        {
            bool decisionSucceeded = Transitions[i].decision.Decide(controller);

            if (decisionSucceeded)
            {
                controller.TransitionToState(Transitions[i].trueState);
            }
            else
            {
                controller.TransitionToState(Transitions[i].falseState);
            }
        }
    }
}
