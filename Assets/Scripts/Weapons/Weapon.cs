using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {


    public Projectil projectil;

    public Weapon(Projectil projectil)
    {
        this.Projectil = projectil;
    }

    public Projectil Projectil
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

    public abstract void shoot();

  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
