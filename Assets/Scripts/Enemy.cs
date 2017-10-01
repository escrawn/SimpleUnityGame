using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    [SerializeField]
    private int health;
    private int damage;
    private float shootSpeed;
    private float speed;
    public GameObject body;

    public Enemy(int health, int damage, float shootSpeed, float speed, GameObject body)
    {
        this.health = health;
        this.damage = damage;
        this.shootSpeed = shootSpeed;
        this.speed = speed;
        this.body = body;
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public float ShootSpeed
    {
        get
        {
            return shootSpeed;
        }

        set
        {
            shootSpeed = value;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public GameObject Body
    {
        get
        {
            return body;
        }

        set
        {
            body = value;
        }
    }

    public abstract void attack();
    public abstract void takeDamage(Projectil projectil);
}
