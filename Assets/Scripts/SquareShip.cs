using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareShip : Enemy
{



    public bool ssDamage = false;

    public SquareShip(int health, int damage, float shootSpeed, float speed, GameObject body) : base(health, damage, shootSpeed, speed, body)
    {
        health = 50;
        damage = 5;
        shootSpeed = 2;
        speed = 0;
        
    }

    public override void attack()
    {

    }

    public override void takeDamage()
    {

    }

    /*
    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.tag == "bulletTrigger")
        {
            Destroy(myCollider.gameObject);
        }
        
    }
     */


    private void doDamage(Enemy enemy)
    {
        if(ssDamage == true)
        {
            enemy.Health -= Damage;
        }
      
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "enemy")
        {

            ssDamage = true;

        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
