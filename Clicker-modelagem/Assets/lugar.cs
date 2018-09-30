using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lugar : Elementos {


    //public string nome;
    //public transicao[] transicoes;
    //public int[] pesos;
    //public int ntransicoes;
    //public int marcacoes=0;
    //public bool[] podepassar;
    //public int teste;
    // Use this for initialization

    public int marcadores;

    public void Create(string name) {
        marcadores = 0;
        nome = name;
    }

    public void RemoveMarker()
    {
        RemoveMarkers(1);
    }

    public void RemoveMarkers(int amount)
    {
        AddMarkers(-amount);
    }

    public void AddMarker()
    {
        AddMarkers(1);
    }

    public void AddMarkers(int amount)
    {
        marcadores += amount;
        if (marcadores < 0) marcadores = 0;
    }


    


}
