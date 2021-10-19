/*
    Autora: Nerea Rodríguez Hernández
    Universidad de La Laguna
    Grado en Ingenería Informática
    Asignatura: Interfaces Inteligentes
    19/10/2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class who : MonoBehaviour {
    public int id = 0;
    private int count = 1;

    void Update() {
        string name = gameObject.name;
        string tag = gameObject.tag;
        Debug.Log(string.Format("Hello! I'm {0} ({1}), with ID {2}. This is my {3}º message!", name, tag, id, count));
        count++;
    }
}

