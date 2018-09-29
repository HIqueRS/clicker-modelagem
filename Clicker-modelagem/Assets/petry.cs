using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class petry : MonoBehaviour {

    //public int nLugares = 0,nTransicoes =0;
    //public lugar[] lugares;
    //public transicao[] transicoes;
    //List<lugar> lugarez;
    //lugar luigar;

    public List<Elementos> elements;
    public List<lugar> lugarez;
    public List<transicao> transicoes;
    public List<Arco> arcos;

	// Use this for initialization
	void Start () {
        elements = new List<Elementos>();
        transicoes = new List<transicao>();
        lugarez = new List<lugar>();
        arcos = new List<Arco>();
        
	}
	
	// Update is called once per frame
	public void clear()
    {
        elements.Clear();
        transicoes.Clear();
        lugarez.Clear();
        arcos.Clear();
    }

    public Elementos GetElement(string name)
    {
        return elements.Find(x => x.nome == name);  
    }

    public lugar GetLugar(string name)
    {
        return lugarez.Find(x => x.nome == name);
    }

    public transicao GetTransicao(string name)
    {
        return transicoes.Find(x => x.nome == name);
    }

    public void CriarLugar(string nome)
    {
        lugar novolugar = new lugar();
        novolugar.Create(nome);
        elements.Add(novolugar);
        lugarez.Add(novolugar);
    }

    public void CriaTransicao(string nome)
    {
        transicao novaTrans = new transicao();
        novaTrans.CreateTransition(nome);
        elements.Add(novaTrans);
        transicoes.Add(novaTrans);
    }

    public bool CriarArco(string nomeInput,string nomeOutput, int peso)
    {
        lugar LugarIn = lugarez.Find(x => x.nome == nomeInput);
        if(LugarIn != null)
        {
            transicao TransicaoOut = transicoes.Find(x => x.nome == nomeOutput);
            if(TransicaoOut == null)
            {
                return false;
            }

            Arco newArco = new Arco();
            newArco.CreateArc(LugarIn, TransicaoOut, 1);
            arcos.Add(newArco);
            return true;
        }

        transicao TransicaoIn = transicoes.Find(x => x.nome == nomeInput);
        if(TransicaoIn != null)
        {
            lugar LugarOut = lugarez.Find(x => x.nome == nomeOutput);
            if (LugarOut == null)
            {
                return false;
            }

            Arco newArco = new Arco();
            newArco.CreateArc(TransicaoIn, LugarOut, 1);
            return true;
        }

        return false;
    }

   public void AddListener (string name, transicao.listener callback)
    {
        //continuo sem saber pra que essa coisa
        transicao Transi = transicoes.Find(x => x.nome == name);
        if (Transi != null)
        {
            Transi.AddListener(callback);
        }
    }

    public void AddMarcas(string name, int qtd)
    {
        lugar newlugar = lugarez.Find(x => x.nome == name);
        if (newlugar != null)
        {
            newlugar.AddMarkers(qtd);
            Process(); 
        }
    }

    public void Process()
    {
        foreach(transicao transicao in transicoes)
        {
            transicao.PreProcess();
        }

        foreach(transicao transicao in transicoes)
        {
            transicao.Process();
        }
    }

    //public void insereCallbackLugar(string nomeLugar, )  não sei como fazer isso aqui pq sla
}
