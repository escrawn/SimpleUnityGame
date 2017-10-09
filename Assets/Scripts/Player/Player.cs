using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private int health;
    [SerializeField]
    private new string name;
    [SerializeField]
    private Rigidbody rbPlayer;
    [SerializeField]
    private int speed;



    public Player(int health, string name,int speed)
    {

        this.Health = health;
        this.Name = name;
        this.Speed = speed;

    }

    public Player()
    {
        this.Health = 1;
        this.Name = "No name";
    }


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        move();
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

    private void move()
    {

        /*
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        */
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxis("Vertical")*speed, 0, -Input.GetAxis("Horizontal")*speed);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
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
}
