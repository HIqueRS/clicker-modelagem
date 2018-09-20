using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicao : MonoBehaviour {


    public string nome;
    public int[] pesos;
    public lugar[] lugares;
   // public int marcadores=0; talvez nem precisa
    public int nlugares;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetLugar(lugar nome,int peso)
    {
        lugares[nlugares] = nome;
        pesos[nlugares] = peso;
        nlugares++;
    }
}
