using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clique : MonoBehaviour {

    public Text score;
    public float Nresources =0.00f;
    public float resourcesPerClick = 1;
    public GameObject Gerencia;
    public int paunocudofloat;
  


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        score.text = "recursos: "+ Gerencia.GetComponent<GerenciadorPetry>().pedro.GetLugar("Recurso").GetMarcadores();
		
	}

    public void Cliked()
    {
        // Nresources += resourcesPerClick;
        paunocudofloat = (int)resourcesPerClick;
        Gerencia.GetComponent<GerenciadorPetry>().pedro.AddMarcas("Recurso",paunocudofloat);
    }
}
