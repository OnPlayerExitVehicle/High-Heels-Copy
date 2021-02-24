using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Walk: MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int legCount = 1;
    [SerializeField] private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        legCount = GetComponent<Pickup>().LegCount;
        //animator.speed = 0.5f;
    }
    private void Update()
    {
        
        transform.position += transform.forward * (Time.deltaTime * speed /** (legCount)*/);
    }

    public void OnLegCountChanged(int newLegCount)
    {
        animator.speed *= 0.75f;
        legCount = newLegCount;
    }
}