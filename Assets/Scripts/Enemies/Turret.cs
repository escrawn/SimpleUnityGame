using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Enemy {

    public Player player;

    public Turret(int health, int damage, float shootSpeed, float speed, GameObject body) : base(health, damage, shootSpeed, speed, body)
    {

        health = 500;
        damage = 5;
        shootSpeed = 0.5f;
        speed = 0;


    }


    public override void takeDamage(Projectil projectil)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        invokeProjectil();
	}
	
	// Update is called once per frame
	void Update () {

    
        transform.LookAt(player.transform.position);
    }


}
