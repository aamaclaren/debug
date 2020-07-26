using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramRunner : MonoBehaviour
{
    [SerializeField] private GameObject currentTarget;
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private bool running = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(running)
        {
            MoveToCurrentTarget();
        }
    }

    private void MoveToCurrentTarget()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, step);

        if(Vector3.Distance(transform.position, currentTarget.transform.position) == 0)
        {
            OnTargetReached();
        }
    }

    private void OnTargetReached()
    {
        IExecutableStatement targetExecutableStatement = currentTarget.GetComponent<IExecutableStatement>();
        if(targetExecutableStatement == null)
        {
            Debug.LogError("Error: target does not have <IExecutableStatement> component... Stopping runner");
            running = false;
            return;
        }

        targetExecutableStatement.ExecuteStatement();
        currentTarget = targetExecutableStatement.GetNextExecutableStatement();
    }
}
