using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour {

    private float rotation;
    private Skybox skybox;

    // Use this for initialization
    void Start () {
        skybox = GetComponent<Skybox>();
    }
	
	// Update is called once per frame
	void Update () {
        skyRotation();
    }

    void skyRotation()
    {
        rotation -= Time.deltaTime * 2;
        skybox.material.SetFloat("_Rotation", rotation);
    }

}
