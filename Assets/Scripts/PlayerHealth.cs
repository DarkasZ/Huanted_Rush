﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;

    public Health healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void DamagePlayer(int Hurt, Vector3 direction)
    {
        currentHealth -= Hurt;

        healthBar.SetHealth(currentHealth);
    }
}