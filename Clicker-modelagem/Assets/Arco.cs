using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arco  {

    public Elementos input;
    public Elementos output;
    public int weight;
    public string nome;

	public void CreateArc(Elementos inpu,Elementos outpu,int peso,string name)
    {
        nome = name;
        input = inpu;
        output = outpu;
        weight = peso;

        input.AddOutput(this); //what you doing here
        output.AddInput(this);
    }

    public void SetPeso(float peso)
    {
        
        weight = (int)peso;
    }

    public int GetPeso()
    {
        return weight;
    }
}
