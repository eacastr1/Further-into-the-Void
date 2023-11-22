using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercraft : Spacecraft
{
    [SerializeField] private int playerHealth; 
    [SerializeField] private int playerSpeed;
    [SerializeField] private int playerDamage;

    private int playerLives;

    public Playercraft(int playerHealth, int playerSpeed, int playerDamage) : base(playerHealth, playerSpeed, playerDamage) 
    {
        this.playerHealth = playerHealth;
        this.playerSpeed = playerSpeed;
        this.playerDamage = playerDamage;
        playerLives = 3;
    }

    // Death function
    public override void Death()
    {
        // Death/Explosion animation
        // Respawn or Game Over
    }

    public void ShootPrimaryFire()
    {

    }

    public void FireLazer()
    {

    }

    public int GetPlayerLives()
    {
        return playerLives;
    }
}
