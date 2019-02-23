using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppings : MonoBehaviour {


    public GameObject gameobj1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gameobj1, transform.position, transform.rotation);
        }
	}
}
