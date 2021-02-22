using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Walk: MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position += transform.forward * (Time.deltaTime * speed);
    }
}