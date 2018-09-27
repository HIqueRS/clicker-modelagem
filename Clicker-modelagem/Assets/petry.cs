using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class petry : MonoBehaviour {

    public int nLugares = 0,nTransicoes =0;
    public lugar[] lugares;
    public transicao[] transicoes;
    List<lugar> lugarez;
    lugar luigar;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void criarLugar(string name)
    {
        lugares[nLugares++].nome = name;
        luigar.nome = name;
        lugarez.Add(luigar);
        
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
            GetLugar(nomeLugar).setTransicao(GetTransicao(nomeTransicao).nome, peso, inibidor);
        }
        else//transicao -> lugar
        {
            GetTransicao(nomeTransicao).SetLugar(GetLugar(nomeLugar).nome, peso);
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
        for(int i =0; i < nLugares; i++)
        {
            if(lugares[nLugares].TemTransicao(nomeTransicao))
            {
                if(!(lugares[nLugares].PodeSeguir(nomeTransicao)))
                {
                    return false;
                }
            }
        }
        return true;
    }

    void executaCiclo()
    {
        for(int i =0; i< nTransicoes; i++)
        {
            if(getStatusTransicao(transicoes[i].nome))
            {
                //matar
                //dar vida
            }
        }
    }

    //public void insereCallbackLugar(string nomeLugar, )  não sei como fazer isso aqui pq sla
}
