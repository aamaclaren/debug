using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramState : MonoBehaviour
{
    private Dictionary<string, string> programStringVariables = new Dictionary<string, string>();
    private Dictionary<string, int> programIntVariables = new Dictionary<string, int>();
    private Dictionary<string, float> programFloatVariables = new Dictionary<string, float>();
    private Dictionary<string, bool> programBoolVariables = new Dictionary<string, bool>();

    void Start() { }

    void Update() { }

    public void SetStringProgramVariable(string key, string value)
    {
        if (programStringVariables.ContainsKey(key))
        {
            programStringVariables[key] = value;
        }
        else
        {
            programStringVariables.Add(key, value);
        }
    }

    public string GetStringProgramVariable(string key)
    {
        return programStringVariables[key];
    }

    public void SetIntProgramVariable(string key, int value)
    {
        if (programIntVariables.ContainsKey(key))
        {
            programIntVariables[key] = value;
        }
        else
        {
            programIntVariables.Add(key, value);
        }
    }

    public int GetIntProgramVariable(string key)
    {
        return programIntVariables[key];
    }

    public void SetFloatProgramVariable(string key, float value)
    {
        if (programFloatVariables.ContainsKey(key))
        {
            programFloatVariables[key] = value;
        }
        else
        {
            programFloatVariables.Add(key, value);
        }
    }

    public float GetFloatProgramVariable(string key)
    {
        return programFloatVariables[key];
    }

    public void SetBoolProgramVariable(string key, bool value)
    {
        if (programBoolVariables.ContainsKey(key))
        {
            programBoolVariables[key] = value;
        }
        else
        {
            programBoolVariables.Add(key, value);
        }
    }

    public bool GetBoolProgramVariable(string key)
    {
        return programBoolVariables[key];
    }

}
