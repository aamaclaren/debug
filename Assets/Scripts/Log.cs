using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : BaseExecutableStatement
{
    [SerializeField] private string message;

    public override void ExecuteStatement()
    {
        Debug.Log(message);
    }
}
