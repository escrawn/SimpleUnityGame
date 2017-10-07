using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody rgbd;
    public int damage;
    public int speed;
    public int size;
    public float shootRate;


    public Projectil(GameObject bullet,Rigidbody rgbd,int damage,int speed,int size,int shootRate)
    {
        
        this.SetProjectil(bullet);
        this.Rgbd = rgbd;
        this.Damage = damage;
        this.Speed = speed;
        this.Size = size;
        this.ShootRate = shootRate;

    }

    public Projectil()
    {
        this.SetProjectil(bullet);
        this.Damage = 0;
        this.Speed = 0;
        this.Size = 0;

    }

    public GameObject GetProjectil()
    {
        return bullet;
    }

    public void SetProjectil(GameObject value)
    {
        bullet = value;
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

    public int Speed
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

    public int Size
    {
        get
        {
            return size;
        }

        set
        {
            size = value;
        }
    }

    public Rigidbody Rgbd
    {
        get
        {
            return rgbd;
        }

        set
        {
            rgbd = value;
        }
    }

    public float ShootRate
    {
        get
        {
            return shootRate;
        }

        set
        {
            shootRate = value;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
