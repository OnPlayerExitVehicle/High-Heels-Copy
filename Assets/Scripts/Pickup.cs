using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject legPrefab;
    [SerializeField] private Transform[] legs = new Transform[2];
    [SerializeField] private Transform[] realLegs = new Transform[2];
    [SerializeField] private int legCount = 1;
    [SerializeField] private EventManager eventManager;

    public int LegCount
    {
        get => legCount;
        private set
        {
            eventManager.onLegCountChanged.Invoke(value);
            legCount = value;
        }
    }
    private Transform temp;

    private void Awake()
    {
        
        for (int i = 0; i < 2; i++)
        {
            legs[i] = transform.GetChild(2 + i);
            realLegs[i] = legs[i].GetChild(0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (String.Equals(other.gameObject.tag, "Pickup"))
        {
            Destroy(other.gameObject);
            //Debug.Log("haydar");
            transform.position += transform.up * realLegs[0].lossyScale.y * 2;
            for (int i = 0; i < 2; i++)
            {
                temp = Instantiate(legPrefab, legs[i]).transform;
                temp.localScale = realLegs[i].localScale;
                temp.position = realLegs[i].position - (realLegs[i].up * realLegs[i].localScale.y * legCount * 2);
            }
            LegCount++;
        }
    }
}