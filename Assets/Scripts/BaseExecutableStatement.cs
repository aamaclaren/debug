using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseExecutableStatement : MonoBehaviour, IExecutableStatement
{
    [SerializeField] protected GameObject nextExecutableStatement;
    public abstract void ExecuteStatement();

    public GameObject GetNextExecutableStatement()
    {
        return nextExecutableStatement;
    }
}
