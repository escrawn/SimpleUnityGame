using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareWeapon : Weapon
{


    public GameObject player;

   
   

    public SquareWeapon(Projectil projectil) : base(projectil)
    {
        this.Prj1 = projectil;
    }

    // Use this for initialization
    void Start()
    {

        invokeProjectil();

    }

    public void invokeProjectil()
    {
        InvokeRepeating("shoot", 0.5f, projectil.shootRate * 0.5f);
    }

    // Update is called once per frame
    void Update()
    {



    }

    override
    public void shoot()
    {

        Vector3 velocity = new Vector3(projectil.speed*5, 0, 0);
        Projectil instance = Instantiate(projectil);
        instance.GetComponent<Rigidbody>().position = player.transform.position+new Vector3(1,0,0);
        instance.GetComponent<Rigidbody>().velocity = velocity;

        instance.GetComponent<AudioSource>().Play();
        Destroy(instance.gameObject,0.8f);




    }

    public GameObject Player
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
            return projectil;
        }

        set
        {
            projectil = value;
        }
    }
}
