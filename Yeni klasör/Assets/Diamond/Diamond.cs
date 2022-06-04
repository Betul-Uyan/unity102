using System;
using UnityEngine;

public class Diamond: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("diamond"))
        {
            Debug.Log("triggered");
            //transform.SetParent(col.transform);
        }
    }
}
