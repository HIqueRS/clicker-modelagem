using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeUpgrade : MonoBehaviour {

    public clique click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int cont = 0;
    public int clickPower;
    public string itemName;
    private float _newCost;
    public GameObject algo;
    public string nomeArco;
    public string NomeTransicao;
    public string NomeLugar;

    // Update is called once per frame
    void Update() {

        itemInfo.text = itemName + "\nCost: " + algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).GetPeso() + "\nQtd: " + algo.GetComponent<GerenciadorPetry>().pedro.GetLugar(NomeLugar).GetMarcadores();

	}

    public void PurchasedUpgrade()
    {
        if(algo.GetComponent<GerenciadorPetry>().pedro.GetTransicao(NomeTransicao).PreProcess())
        {
            algo.GetComponent<GerenciadorPetry>().pedro.GetTransicao(NomeTransicao).Process();
            if(nomeArco != "A_Nave1" || nomeArco != "A_Final")
                algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).SetPeso(algo.GetComponent<GerenciadorPetry>().pedro.GetArco(nomeArco).GetPeso() * 1.15f);
            cont++;
            click.resourcesPerClick += clickPower;
        }
        

        //if(click.Nresources >= cost)
        //{
        //    click.Nresources -= cost;
        //    cont++;
        //    click.resourcesPerClick += clickPower;
        //    cost = Mathf.Round(cost * 1.15f);
        //    {
        //        _newCost = Mathf.Pow(cost, _newCost = cost);
        //    }
        //}
    }


    //só pra deixar o meu pensamento salvo em algum lugar pq eu não vou mais fazer algo hj mas a ideia tá aqui
    //quando clicar no botão puxar a transição do botão e se ela tiver disponivel processar ela e depois setar o novo peso do arco
    //um obj vai ficar com o gerenciador e os botões vão receber esse obj e vão usar a pegar as coisas de lá e eras isso
}
