using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 500f;

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float upMove = Input.GetAxis("Up") * rotationSpeed * Time.deltaTime;
        transform.Translate(new Vector3(horizontalMove, 0f, verticalMove));
        transform.Rotate(new Vector3(0f, upMove, 0f));
    }
}
