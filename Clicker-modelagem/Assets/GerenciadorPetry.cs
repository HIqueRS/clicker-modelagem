using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorPetry : MonoBehaviour {

    public petry pedro;

	// Use this for initialization
	void Start () {
        //só vai startar todo mundo e  os outros q vão setar quando vai passar pro proximo estado

        //decidindo os nomes das pirras
        //Recursos - lugar de recursos
        //RecursoCombustivel - arco1 Recurso -> Combustivel
        //RecursoMinerador - arco2 Recurso -> Minerador
        //RecursoColetor - arco3 Recurso -> Coletor
        //RecursoConstrutor - arco4 Recurso -> Construtor
        //T

        pedro.CriarLugar("Recurso");

        pedro.CriaTransicao("T_Combustivel");
        pedro.CriarArco("Recurso", "T_Combustivel", 12*10, "A_Combustivel");
            pedro.CriarLugar("Combustivel");
            pedro.CriarArco("T_Combustivel", "Combustivel", 1, "Arco1");

            pedro.CriaTransicao("T_Final");
            pedro.CriarArco("Combustivel", "T_Final", 1, "Arco2");

        pedro.CriaTransicao("T_Minerador");
        pedro.CriarArco("Recurso", "T_Minerador", 12, "A_Minerador");
            pedro.CriarLugar("Minerador");
            pedro.CriarArco("T_Minerador", "Minerador", 1, "Arco3");

            pedro.CriarArco("Minerador", "T_Final", 1, "Arco4");
            

        pedro.CriaTransicao("T_Coletor");
        pedro.CriarArco("Recurso", "T_Coletor", 12 * 5, "A_Coletor");
            pedro.CriarLugar("Coletor");
            pedro.CriarArco("T_Coletor", "Coletor", 1, "Arco5");

                pedro.CriaTransicao("T_Nave");
                pedro.CriarArco("Coletor", "T_Nave", 1, "A_Nave1");

                pedro.CriarLugar("Nave");
                pedro.CriarArco("T_Nave", "Nave", 1, "Arco6");

                pedro.CriarArco("Nave", "T_Final", 1, "Arco7");


        pedro.CriaTransicao("T_Construtor");
        pedro.CriarArco("Recurso", "T_Construtor", 12 * 10, "A_Construtor");

            pedro.CriarLugar("Construtor");
            pedro.CriarArco("T_Construtor", "Construtor", 1, "Arco8");

            pedro.CriarArco("Construtor", "T_Nave", 1, "A_Nave2");

        pedro.CriarLugar("FugaDaLua");
        pedro.CriarArco("T_Final", "FugaDaLua", 1, "ArcoFinal");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
