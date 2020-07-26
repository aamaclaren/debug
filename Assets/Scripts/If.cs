using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class If : MonoBehaviour, IExecutableStatement
{
    [SerializeField] protected bool conditionPassed;
    [SerializeField] private GameObject conditionPassedNextExecutableStatement;
    [SerializeField] private GameObject conditionFailedNextExecutableStatement;
    public abstract void ExecuteStatement();

    public GameObject GetNextExecutableStatement()
    {
        return conditionPassed ? conditionPassedNextExecutableStatement : conditionFailedNextExecutableStatement;
    }
}
