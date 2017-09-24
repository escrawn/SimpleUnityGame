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



    public Player(int health, string name)
    {

        this.Health = health;
        this.Name = name;

    }

    public Player()
    {
        this.Health = 0;
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
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
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



}
