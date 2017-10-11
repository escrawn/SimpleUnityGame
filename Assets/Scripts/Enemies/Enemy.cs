using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    [SerializeField]
    private int health;
    private int damage;
    [SerializeField]
    private float shootSpeed;
    private float speed;
    public Projectil projectil;
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


    public void lifeControll()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

   
    public  void shoot()
    {
        Vector3 velocity = new Vector3(projectil.speed * 5, 0, 0);
        Projectil instance = Instantiate(projectil);
        instance.GetComponent<Rigidbody>().position = body.transform.position + new Vector3(1, 0, 0);
        instance.GetComponent<Rigidbody>().velocity = transform.forward*projectil.speed*5;
   

        instance.GetComponent<AudioSource>().Play();
        Destroy(instance.gameObject, 0.8f);
    }

    public void invokeProjectil()
    {
        InvokeRepeating("shoot", 0.5f, projectil.shootRate * 0.5f);
    }
    public abstract void takeDamage(Projectil projectil);
}
