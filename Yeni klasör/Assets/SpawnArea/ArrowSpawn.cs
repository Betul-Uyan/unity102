using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{

    public GameObject Arrow;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol t�ka bas�l�rsa ok at�l�r

            ArrowSpawner();
        
    }

    void ArrowSpawner()
    {
        Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmas� i�in gerekli fonksiyon
    }
}
