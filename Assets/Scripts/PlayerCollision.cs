﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
   {


        if (collisionInfo.collider.tag == "Obstacles")
            {
            Debug.Log("We hit something");

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }


   }



}
