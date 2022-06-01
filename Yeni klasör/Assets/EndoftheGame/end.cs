using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject SpinningCircle;
    public GameObject ArrowSpawn;

    // Update is called once per frame
    public void finish()
    {
        SpinningCircle.GetComponent<SpinningCircle>().enabled = false;
        ArrowSpawn.GetComponent<ArrowSpawn>().enabled = false;
        
    }
}


