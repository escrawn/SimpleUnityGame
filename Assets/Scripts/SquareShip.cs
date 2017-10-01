using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareShip : Enemy
{



    public bool ssDamage = false;

    public SquareShip(int health, int damage, float shootSpeed, float speed, GameObject body) : base(health, damage, shootSpeed, speed, body)
    {
        this.Health = 100;
        this.Damage = 10;
        this.ShootSpeed = 2;
        this.Speed = 0;
        
        
    }


    public override void attack()
    {

    }

    override
    public void takeDamage(Projectil projectil)
    {

    }

    private void doDamage(Enemy enemy)
    {
      
    }

    private void controllDamage()
    {
        if(Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {


        Projectil projectil = (Projectil) other.GetComponent("Projectil");

        if (other.gameObject.tag == "bulletTrigger")
        {

            this.Health -= projectil.Damage;
            Destroy(other.gameObject);

        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controllDamage();
    }
}
