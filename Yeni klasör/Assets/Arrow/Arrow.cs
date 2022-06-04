using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool hareketkısıtlı;
    public GameObject Manager;

    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");  //manager tagine sahip oyun nesnesini bul managera eşitle
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hareketkısıtlı == false)
        if (hareketkısıtlı == false)
        {

            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); //oku yukarı doğru hareket ettirir
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "SpinningCircle")
        {
            transform.SetParent(col.transform);
            hareketkısıtlı = true;
        }
        if (col.gameObject.tag == "darts")   //darts prefabına değerse oyun biter
        {
            //Manager.GetComponent<end>().finish();

        }
    }
}
