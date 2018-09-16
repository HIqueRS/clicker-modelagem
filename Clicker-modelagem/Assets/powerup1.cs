using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerup1 : MonoBehaviour {

    public Button planet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void power()
    {
        planet.GetComponent<clique>().resourcesPerClick += 1;
    }
}
