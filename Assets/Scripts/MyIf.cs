using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIf : If
{
    [SerializeField] protected ProgramState programState;
    public override void ExecuteStatement()
    {
        conditionPassed = programState.GetIntProgramVariable("x") > 20;
    }
}
