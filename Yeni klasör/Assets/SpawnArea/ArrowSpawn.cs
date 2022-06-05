using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    //TODO:Trigger eklenerek yeþil kutunun vurulmasý tetiklenecek.
    //TODO:Ok'un position bilgisi generic çekilip transform.position.y'e eþitlenecek.
    //TODO:yeniden gelen ok hakký bitene kadar tekrar atýlabilecek.
    //TODO:Vuruþ,ýska,bitiþ olarak hata mesajlarý.


    public GameObject Arrow;
    public int remainingArrow=5; //kalan ok sayýsý
    public bool isGameEnded = false;
    public float restartDelay = 5f;
    bool isStarted = false;
    public Collider2D col;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol týka basýlýrsa ok atýlýr
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

        //Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmasý için gerekli fonksiyon
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
           // Debug.Log($"The End !\nYour Score:{}");/*score deðiþkeninden gelecek bilgi*/
            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Mevcut scene için düzenlenmeli.
    }
}
