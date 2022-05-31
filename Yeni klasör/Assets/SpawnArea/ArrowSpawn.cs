using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{

    public GameObject Arrow;
    public int remainingArrow; //kalan ok sayýsý
    public bool isGameEnded = false;
    public float restartDelay = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //sol týka basýlýrsa ok atýlýr
            remainingArrow--;
        if (remainingArrow != 0)
            ArrowSpawner();
        else FinishTheGame();
    }

    void ArrowSpawner()
    {
        Instantiate(Arrow, transform.position, transform.rotation); //ok spawnlanmasý için gerekli fonksiyon
    }

    void FinishTheGame()
    {
        if (isGameEnded==false)
        {
            isGameEnded=true;
            Debug.Log($"The End !\nYour Score:{/*score deðiþkeninden gelecek bilgi*/}");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Mevcut scene için düzenlenmeli.
    }
}
