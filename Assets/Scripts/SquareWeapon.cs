using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareWeapon : Weapon
{


    public Player player;
    public Projectil prj1;


   

    public SquareWeapon(Projectil projectil) : base(projectil)
    {
        this.Prj1 = projectil;
    }

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("shoot", 0.5f, prj1.shootRate);

    }


    // Update is called once per frame
    void Update()
    {



    }

    override
    public void shoot()
    {

        Vector3 velocity = new Vector3(prj1.speed, 0, 0);
        Projectil instance = Instantiate(prj1);
        instance.GetComponent<Rigidbody>().position = player.transform.position;
        instance.GetComponent<Rigidbody>().velocity = velocity;

        instance.GetComponent<AudioSource>().Play();
        Destroy(instance.gameObject,0.8f);




    }

    public Player Player
    {
        get
        {
            return player;
        }

        set
        {
            player = value;
        }
    }

    public Projectil Prj1
    {
        get
        {
            return prj1;
        }

        set
        {
            prj1 = value;
        }
    }
}
