using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Goal Reached");
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.isGoalReached = true;
            Debug.Log("Goal Reached");
        }
    }
}
