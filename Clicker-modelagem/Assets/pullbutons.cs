using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pullbutons : MonoBehaviour {

    public bool click;
    public Button b1,b2,b3,b4,b5,b6;


	// Use this for initialization
	void Start () {
        click = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pull()
    {
        if (!click)
        {
            transform.position += new Vector3(-186, 0, 0);
            b1.transform.position += new Vector3(-186, 0, 0);
            b2.transform.position += new Vector3(-186, 0, 0);
            b3.transform.position += new Vector3(-186, 0, 0);
            b4.transform.position += new Vector3(-186, 0, 0);
            b5.transform.position += new Vector3(-186, 0, 0);
            b6.transform.position += new Vector3(-186, 0, 0);
            click = !click;
        }
        else
        {
            transform.position += new Vector3(+186, 0, 0);
            b1.transform.position += new Vector3(+186, 0, 0);
            b2.transform.position += new Vector3(+186, 0, 0);
            b3.transform.position += new Vector3(+186, 0, 0);
            b4.transform.position += new Vector3(+186, 0, 0);
            b5.transform.position += new Vector3(+186, 0, 0);
            b6.transform.position += new Vector3(+186, 0, 0);
            click = !click;
        }
       
       
    }
}
