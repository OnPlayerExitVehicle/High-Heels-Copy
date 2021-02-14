using System;
using UnityEditor;
using UnityEngine;

public class Walk: MonoBehaviour
{
    //private Animator animator;
    [SerializeField] private float speed;

    private void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position += transform.forward * (Time.deltaTime * speed);
    }
}