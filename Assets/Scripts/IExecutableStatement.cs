using UnityEngine;

public interface IExecutableStatement
{
    void ExecuteStatement();
    GameObject GetNextExecutableStatement();
}
