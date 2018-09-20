using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class petry : MonoBehaviour {

    public int nLugares = 0,nTransicoes =0;
    public lugar[] lugares;
    public transicao[] transicoes;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void criarLugar(string name)
    {
        lugares[nLugares++].nome = name;
    }

    public void removeLugar(string name)
    {
        //tirar tudo do lugar e procurar nas transições se alguem tem esse lugar
    }

    public void criaTransicao(string nomeTransicao)
    {
        transicoes[nTransicoes++].nome = nomeTransicao;
    }

    public void removeTransicao(string nomeTransicao)
    {

    }

    public void criaConexao(string nomeLugar,string nomeTransicao, int peso, bool ehEntrada, bool inibidor)
    {
        if (ehEntrada)//lugar -> transicao
        {
            GetLugar(nomeLugar).setTransicao(GetTransicao(nomeTransicao), peso, inibidor);
        }
        else//transicao -> lugar
        {
            GetTransicao(nomeTransicao).SetLugar(GetLugar(nomeLugar), peso);
        }
    }

    public lugar GetLugar(string nomelugar)
    {
        for(int x =0; x < nLugares; x++)
        {
            if(nomelugar == lugares[x].nome)
            {
                return lugares[x];
            }
        }
        return lugares[0];
    }

    public transicao GetTransicao(string nomeTran)
    {
        for(int x=0; x< nTransicoes;x++)
        {
            if (nomeTran== transicoes[x].nome)
            {
                return transicoes[x];
            }
        }
        return transicoes[0];
    }

    public void removeConexao(string nomeLugar, string nomeTransicao,bool ehEntrada)
    {
        //como faz pra remover? 
    }

    public void setaMarcacaoLugar(string nomeLugar,int qtdMarcas)
    {
        GetLugar(nomeLugar).SetMarcadores(qtdMarcas);
    }

    public void incMarcacaoLugar(string nomeLugar, int qtdMarcas)
    {
        GetLugar(nomeLugar).AddMarcadores(qtdMarcas);
    }

    public int getMarcacao(string nome)
    {
        return GetLugar(nome).GetMarcadores();
    }

    public bool getStatusTransicao(string nomeTransicao)
    {
        return true;
    }

    void executaCiclo()
    {

    }

    //public void insereCallbackLugar(string nomeLugar, )  não sei como fazer isso aqui pq sla
}
