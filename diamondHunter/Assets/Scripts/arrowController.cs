using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class arrowController : MonoBehaviour
{
    [SerializeField] private GameObject Text;
    [SerializeField] private GameObject Text2;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(name: "click");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("diamond"))
        {
            _animator.SetTrigger(name: "shoot");
            Destroy(GameObject.FindWithTag("diamond"));
            Text.SetActive(true);

        }
        else
        {
            _animator.SetTrigger(name: "miss");
            Text2.SetActive(true);
         }
    }
}
