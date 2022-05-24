using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{

    public GameObject Arrow;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol týka basýlýrsa ok atýlýr

            ArrowSpawner();
        
    }

    void ArrowSpawner()
    {
        Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmasý için gerekli fonksiyon
    }
}
