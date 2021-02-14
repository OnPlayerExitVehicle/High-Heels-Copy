using System;
using UnityEditor;
using UnityEngine;

public class Walk: MonoBehaviour
{
    //private Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private GameObject legPrefab;
    private Transform[] legs = new Transform[2];
    

    private void Awake()
    {
        for (int i = 0; i < 2; i++)
        {
            legs[i] = transform.GetChild(2 + i);
        }
        
        //animator = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position += transform.forward * (Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (String.Equals(other.gameObject.tag, "Pickup"))
        {
            Debug.Log("haydar");
            transform.position += transform.up * legPrefab.transform.localScale.y * 2;
            for (int i = 0; i < 2; i++)
            {
                legs[i] = Instantiate(legPrefab, legs[i].transform.position - ((-legs[i].transform.up) * (legs[i].localScale.y * 2)), legs[i].rotation, legs[i]).transform;
            }
            
        }
    }
}