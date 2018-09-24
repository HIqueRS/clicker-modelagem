using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lugar : MonoBehaviour {


    public string nome;
    public transicao[] transicoes;
    public int[] pesos;
    public int ntransicoes;
    public int marcacoes=0;
    public bool[] podepassar;
    public int teste;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTransicao(string nomeTransicao,int peso,bool inibidor)//talvez vai precisar sobrecarregar os operadores
    {
        transicoes[ntransicoes].nome = nomeTransicao;
        pesos[ntransicoes] = peso;
        podepassar[ntransicoes] = false;
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
        for (int i = 0; i < ntransicoes; i++)
        {
            if(marcacoes >= pesos[i])
            {
                podepassar[i] = true;
            }

            if (transicoes[i].nome == nome)
            {
                teste = i;
            }
        }
        return podepassar[teste];
    }
}
