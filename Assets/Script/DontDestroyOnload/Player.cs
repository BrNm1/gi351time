using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerManager manager;
    public PlayerMovement movement;

    private void Awake()
    {
        manager.enabled = true;
        movement.enabled = true;
    }
}
