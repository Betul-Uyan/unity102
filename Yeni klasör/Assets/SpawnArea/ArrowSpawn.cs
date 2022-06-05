using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    //TODO:Trigger eklenerek ye�il kutunun vurulmas� tetiklenecek.
    //TODO:Ok'un position bilgisi generic �ekilip transform.position.y'e e�itlenecek.
    //TODO:yeniden gelen ok hakk� bitene kadar tekrar at�labilecek.
    //TODO:Vuru�,�ska,biti� olarak hata mesajlar�.


    public GameObject Arrow;
    public int remainingArrow=5; //kalan ok say�s�
    public bool isGameEnded = false;
    public float restartDelay = 5f;
    bool isStarted = false;
    public Collider2D col;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol t�ka bas�l�rsa ok at�l�r
        {
            isStarted = true;
            remainingArrow--;
            Debug.Log($"Remaining arrow: {remainingArrow}");
        }
            
        if (isStarted)
        {
            if (remainingArrow>0)
            {
                ArrowSpawner();
            }
            else
            {
                Debug.Log($"Arrow not found!");
            }
        }
            
        //remainingArrow--;
        //if (remainingArrow != 0)
        //else FinishTheGame();
    }

    void ArrowSpawner()
    {
        float startPos = transform.position.y;

        //Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmas� i�in gerekli fonksiyon
        float movespeed = 0.01f;
        movespeed += 0.01f;
        //transform.position = new Vector3(transform.position.x, transform.position.y + movespeed);
        transform.Translate(movespeed, 0, 0);

        Invoke("SetOriginalPosition", 1.1f);

    }

    public void SetOriginalPosition()
    {
        transform.position = new Vector3(transform.position.x, -2.5f);
        isStarted = false;
    }

    void FinishTheGame()
    {
        if (isGameEnded==false)
        {
            isGameEnded=true;
           // Debug.Log($"The End !\nYour Score:{}");/*score de�i�keninden gelecek bilgi*/
            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Mevcut scene i�in d�zenlenmeli.
    }
}
