using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clique : MonoBehaviour {

    public Text score;
    public int Nresources =0;
    public int resourcesPerClick = 1;
  


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
