using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
   public float speed = 1.0f;
   public Transform goal;
   public float accuracy;

   private void Start()
   {
   }

   private void LateUpdate()
   {
      this.transform.LookAt(goal.position);
      Vector3 direction = goal.position - this.transform.position;
      Debug.DrawRay(this.transform.position,direction,Color.red);
      if (direction.magnitude > accuracy)
          this.transform.Translate(direction.normalized * (speed * Time.deltaTime),Space.World);

   }
}
