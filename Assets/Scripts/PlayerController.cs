using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilprefab;
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnProjectile()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(projectilprefab, transform.position, projectilprefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(projectilprefab, transform.position, -projectilprefab.transform.rotation);
        }
        
    }
}
