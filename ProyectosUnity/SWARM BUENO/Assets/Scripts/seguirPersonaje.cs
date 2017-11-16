using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirPersonaje : MonoBehaviour {

    public Transform personaje;
    public float altura = 0f;

    void Update()
    {
        transform.position = new Vector3(personaje.position.x, personaje.position.y+altura, transform.position.z);

    }
}
