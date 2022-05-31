using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{

    public GameObject Arrow;
    public int remainingArrow; //kalan ok say�s�
    public bool isGameEnded = false;
    public float restartDelay = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol t�ka bas�l�rsa ok at�l�r
            remainingArrow--;
        if (remainingArrow != 0)
            ArrowSpawner();
        else FinishTheGame();
    }

    void ArrowSpawner()
    {
        Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmas� i�in gerekli fonksiyon
    }

    void FinishTheGame()
    {
        if (isGameEnded==false)
        {
            isGameEnded=true;
            Debug.Log($"The End !\nYour Score:{/*score de�i�keninden gelecek bilgi*/}");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Mevcut scene i�in d�zenlenmeli.
    }
}
