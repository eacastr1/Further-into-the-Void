using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spacecraft : MonoBehaviour
{
    // What does a space craft do?
    private int health, speed, damage;

    private Rigidbody2D rb;

    // Spacecraft is not stationary
    public Spacecraft(int health, int speed, int damage) {
        this.health = health;
        this.speed = speed;
        this.damage = damage;
    }
    // Spacecraft is stationary.
    public Spacecraft(int health, int damage) {
        this.health = health;
        this.speed = 0;
        this.damage = damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Death logic is different based on whether enemy or player
    public abstract void Death();

    void Move(Vector2 direction) 
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    void TakeDamage(int damageTaken)
    {
        int newHealth = health - damageTaken;
        
        if(newHealth > 0)
        {
            SetHealth(health -= damageTaken);
        }
        else 
        {
            Death();
        }
    }

    int GetHealth()
    {
        return health;
    }

    void SetHealth(int health)
    {
        this.health = health;
    }

    int GetSpeed()
    {
        return speed;
    }

    int GetDamage()
    {
        return damage;
    }
}
