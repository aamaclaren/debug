using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIntegerVariable : BaseExecutableStatement
{
    [SerializeField] private ProgramState programState;
    [SerializeField] private string key;
    [SerializeField] private int value;

    public override void ExecuteStatement()
    {
        programState.SetIntProgramVariable(key, value);
    }
}
