using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    end endofthegamesc;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + Vector2.up*speed*Time.deltaTime); //oku yukarý doðru hareket ettirir
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "darts")   //darts prefabýna deðerse oyun biter
        {

        }
    }
}
