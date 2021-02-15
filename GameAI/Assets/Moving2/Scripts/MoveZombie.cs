using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZombie : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.5f;
    public float accuracy = 1.0f;

    private void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        this.transform.LookAt(lookAtGoal);
        if (Vector3.Distance(this.transform.position, lookAtGoal) > accuracy)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
