using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 7f;
    private int xRange = 10;
    private int yRange = 7;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); //movimiento hacia adelante constante

        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.y > yRange || transform.position.y < -yRange) //si sobrepasa el límite de la cámara
        {
            Destroy(gameObject); //destruimos el proyectil
        }   
    }
}
