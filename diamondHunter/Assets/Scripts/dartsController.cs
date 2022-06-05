using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartsController : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("arrow"))
        {
            _animator.SetTrigger(name: "haveShot");
        }
    }
}
