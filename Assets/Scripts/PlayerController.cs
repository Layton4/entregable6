using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilprefab;
    private Quaternion up = Quaternion.Euler(0,0,0); //posici�n de rotaci�n para mirar hacia arriba
    private Quaternion down = Quaternion.Euler(0, 0, 180); //posici�n rotaci�n para mirar hacia abajo
    private Quaternion right = Quaternion.Euler(0, 0, -90); //posici�n rotaci�n para mirar hacia la derecha
    private Quaternion left = Quaternion.Euler(0, 0, 90); //posici�n rotaci�n para mirar hacia la izquierda

    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //al pulsar tecla arriba
        {
            SpawnProjectile(up); //spawn proyectil que se mueva hacia arriba
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //al pulsar tecla abajo
        {
            SpawnProjectile(down);  //spawn proyectil que se mueva hacia abajo
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //al pulsar tecla derecha
        {
            SpawnProjectile(right); //spawn proyectil que se mueva hacia derecha
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //al pulsar tecla izquierda
        {
            SpawnProjectile(left); //spawn protectil que se mueva a la izquierda
        }

    }

    public void SpawnProjectile(Quaternion rotation) // funci�n que spawnea el proyectil que le indicamos en la variable projectilprefab
    {
        Instantiate(projectilprefab, transform.position, rotation); //prefab, en la posici�n del player y con la rotaci�n indicada
    }
}
