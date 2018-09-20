using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lugar : MonoBehaviour {


    public string nome;
    public transicao[] transicoes;
    public int[] pesos;
    public int ntransicoes;
    public int marcacoes=0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTransicao(transicao nomeTransicao,int peso,bool inibidor)//talvez vai precisar sobrecarregar os operadores
    {
        transicoes[ntransicoes] = nomeTransicao;
        pesos[ntransicoes] = peso;
        ntransicoes++;
    }

    public void SetMarcadores(int marcas)
    {
        marcacoes = marcas;
    }

    public void AddMarcadores(int marcas)
    {
        marcacoes += marcas;
    }

    public int GetMarcadores()
    {
        return marcacoes;
    }

    public bool TemTransicao(string nome)
    {
        for(int i = 0; i < ntransicoes; i++)
        {
            if(transicoes[i].nome == nome)
            {
                return true;
            }
        }
        return false;
    }

    public bool PodeSeguir(string nome)
    {
        //aaaah cansei já
    }
}
