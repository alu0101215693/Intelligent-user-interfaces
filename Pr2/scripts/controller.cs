/*
    Autora: Nerea Rodríguez Hernández
    Universidad de La Laguna
    Grado en Ingenería Informática
    Asignatura: Interfaces Inteligentes
    Práctica 2: Introducción a los scripts en Unity
    19/10/2021
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 500f;

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float upMove = Input.GetAxis("Up") * rotationSpeed * Time.deltaTime;
        transform.Translate(new Vector3(horizontalMove, 0f, verticalMove));
        transform.Rotate(new Vector3(0f, upMove, 0f));
    }
}
