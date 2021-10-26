using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderController : MonoBehaviour
{
    [Header("General")]
    public float generalSpeed = 0.5f;

    [Header("Cylinder A")]
    public bool isTypeA = false;
    public float typeASpeed = 5f;

    [Header("Cylinder B")]
    public bool isTypeB = false;
    public float typeBSpeed = 5f;

    private Rigidbody rb;
    private GameObject player;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if ((Input.GetKeyDown("space") && isTypeA))
        {
            repel();
        }
        else if (isTypeB)
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance <= typeBSpeed) repel();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameController.instance.updateScore(1);
            transform.localScale += new Vector3(generalSpeed, generalSpeed, generalSpeed);
        }    
    }

    private void repel()
    {
        Vector3 forceDirection = Vector3.Normalize(transform.position - player.transform.position);
        rb.AddForce(forceDirection * typeASpeed);
    }
}
