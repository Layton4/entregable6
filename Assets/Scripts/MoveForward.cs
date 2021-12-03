using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 7f;
    private int xRange = 13;
    private int yRange = 8;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); //movimiento hacia adelante del objeto constante

        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.y > yRange || transform.position.y < -yRange) //si sobrepasa el límite de la cámara
        {
            Destroy(gameObject); //destruimos el proyectil
        }   
    }
}
