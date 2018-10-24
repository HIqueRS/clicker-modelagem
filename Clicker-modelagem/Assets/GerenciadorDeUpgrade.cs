using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class GerenciadorDeUpgrade : MonoBehaviour {

    public clique click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int cont = 0;
    public int clickPower;
    public int resurcespersec;
    public string itemName;
    private float _newCost;
    public GameObject algo;
    public string nomeArco;
    public string NomeTransicao;
    public string NomeLugar;
    int X = 6356, a = 48271, c = 0, m = 2147483647,coletores;
    public bool naosereprima = false;
    

    // Update is called once per frame
    void Update() {

        itemInfo.text = itemName + "\nCost: " + algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).GetPeso() + "\nQtd: " + algo.GetComponent<GerenciadorPetry>().pedro.GetLugar(NomeLugar).GetMarcadores();

        coletores = algo.GetComponent<GerenciadorPetry>().pedro.GetLugar("Coletor").GetMarcadores();

        if (naosereprima)
        {
            algo.GetComponent<GerenciadorPetry>().pedro.AddMarcas("Recurso", resurcespersec);
            naosereprima = false;
        }
	}

    void Start()
    {
        new Thread (Multitread).Start();

    }

    public void PurchasedUpgrade()
    {
        if(algo.GetComponent<GerenciadorPetry>().pedro.GetTransicao(NomeTransicao).PreProcess())
        {
            algo.GetComponent<GerenciadorPetry>().pedro.GetTransicao(NomeTransicao).Process();
            if (nomeArco == "A_Final")
            {
                SceneManager.LoadScene(1);
            }

            if (nomeArco != "A_Nave1" || nomeArco != "A_Final")
                algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).SetPeso(algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).GetPeso() * 1.15f);
            cont++;
            click.resourcesPerClick += clickPower;

        }
        

      
    }

    public void Multitread()
    {
        for(int xis = 0; xis < 1000;X++)
        {
            if (coletores > 0)//algo.GetComponent<GerenciadorPetry>().pedro.GetLugar("Coletor").GetMarcadores() > 0)
            {
                Thread.Sleep(randomico() % (180 + coletores));//+ algo.GetComponent<GerenciadorPetry>().pedro.GetLugar("Coletor").GetMarcadores()));
                // algo.GetComponent<Gerenciado/Petry>().pedro.AddMarcas("Recurso", resurcespersec);
                //aaaaah();
                naosereprima = true;
            }
           

        }
    }

    public int randomico()
    {
        X = (a * X + c) % m;
        if(X<0)
        {
            X *= -1;
        }
        return X;
    }

    public void aaaaah()
    {
        algo.GetComponent<GerenciadorPetry>().pedro.AddMarcas("Recurso", resurcespersec);
    }


    //só pra deixar o meu pensamento salvo em algum lugar pq eu não vou mais fazer algo hj mas a ideia tá aqui
    //quando clicar no botão puxar a transição do botão e se ela tiver disponivel processar ela e depois setar o novo peso do arco
    //um obj vai ficar com o gerenciador e os botões vão receber esse obj e vão usar a pegar as coisas de lá e eras isso
}
