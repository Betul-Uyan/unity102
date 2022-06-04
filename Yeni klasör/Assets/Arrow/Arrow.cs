using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool hareketkýsýtlý;
    public GameObject Manager;

    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");  //manager tagine sahip oyun nesnesini bul managera eþitle
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hareketkýsýtlý == false)
        if (hareketkýsýtlý == false)
        {

            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); //oku yukarý doðru hareket ettirir
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "SpinningCircle")
        {
            transform.SetParent(col.transform);
            hareketkýsýtlý = true;
        }
        if (col.gameObject.tag == "darts")   //darts prefabýna deðerse oyun biter
        {
            //Manager.GetComponent<end>().finish();

        }
    }
}
