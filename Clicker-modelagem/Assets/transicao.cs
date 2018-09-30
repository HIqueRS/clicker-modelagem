using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicao : Elementos {

    public delegate void listener(); //que porra é essa

    public List<listener> listeners; //serio oq diabos isso faz?

    public bool canProcess;


    // Use this for initialization
    public void CreateTransition  (string name) {
        nome = name;
        listeners = new List<listener>();
	}
	
	public void AddListener(listener liste)
    {
        listeners.Add(liste);
    }

    public bool PreProcess()
    {
        canProcess = false;
        if (inputs.Count == 0) return false;

        foreach (Arco inputArc in inputs)
        {
            lugar place = inputArc.input as lugar;
            if (place.marcadores < inputArc.weight) return false;
        }
        canProcess = true;
        return true;
    }

    public bool Process()
    {
        if (!canProcess) return false;

        foreach (Arco inputArc in inputs)
        {
            lugar place = inputArc.input as lugar;
            place.RemoveMarkers(inputArc.weight);
        }

        foreach (Arco outputArc in outputs)
        {
            lugar place = outputArc.output as lugar;
            place.AddMarkers(outputArc.weight);
        }

        foreach (listener list in listeners) list();

        return true;
    }
}