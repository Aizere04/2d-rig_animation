using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private Animator _animator;
    [SerializeField] private KeyCode Attack;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        if (Input.GetKeyDown(Attack))
        {
            _animator.SetTrigger("Attack");
        }
    }
}
