using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elementos  {

    public string nome;

    public List<Arco> inputs;
    public List<Arco> outputs;

	// Use this for initialization
	public Elementos () {
        outputs = new List<Arco>();
        inputs = new List<Arco>();
    }

    public void create()
    {
        outputs = new List<Arco>();
        inputs = new List<Arco>();
    }

    public void SetName(string name)
    {
        nome = name;
    }

    public void AddInput(Arco arc)
    {
        inputs.Add(arc);
    }

    public void AddOutput (Arco arc)
    {
        outputs.Add(arc);
    }

    //public PetriNetElement(string name)
    //{
    //    outputs = new List<PetriNetArc>();
    //    inputs = new List<PetriNetArc>();

    //    this.name = name;
    //} why you doing this??

  
}
