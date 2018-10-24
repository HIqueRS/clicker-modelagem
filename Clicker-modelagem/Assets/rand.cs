using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rand : MonoBehaviour {

    public  int X=6356,a= 48271, c=0,m= 2147483647;

	public int Randao()
    {
        X = (a * X + c) % m;
        return X;
    }
	
}