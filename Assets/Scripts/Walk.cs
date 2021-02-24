using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Walk: MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int legCount = 1;
    private void Awake()
    {
        legCount = GetComponent<Pickup>().LegCount;
    }
    private void Update()
    {
        transform.position += transform.forward * (Time.deltaTime * speed * (legCount));
    }

    public void OnLegCountChanged(int newLegCount)
    {
        legCount = newLegCount;
    }
}