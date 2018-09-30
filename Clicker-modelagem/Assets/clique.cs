using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clique : MonoBehaviour {

    public Text score;
    public float Nresources =0.00f;
    public float resourcesPerClick = 1;
  


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        score.text = "recursos: "+ Nresources;
		
	}

    public void Cliked()
    {
        Nresources += resourcesPerClick;
    }
}
