using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMapa : MonoBehaviour {



  


    void movimientoMapa()
    {
        Vector3 movimiento = new Vector3(20, 0, 0);

        
        this.transform.position = transform.position + movimiento*Time.deltaTime;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movimientoMapa();
	}
}
