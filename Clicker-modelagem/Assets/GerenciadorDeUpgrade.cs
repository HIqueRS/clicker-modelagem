﻿using System.Collections;
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

    // Update is called once per frame
    void Update() {

        itemInfo.text = itemName + "\nCost: " + cost + "\n Power" + clickPower;

	}

    public void PurchasedUpgrade()
    {
        if(click.Nresources >= cost)
        {
            click.Nresources -= cost;
            cont++;
            click.resourcesPerClick += clickPower;
            cost = Mathf.Round(cost * 1.15f);
            {
                _newCost = Mathf.Pow(cost, _newCost = cost);
            }
        }
    }
}