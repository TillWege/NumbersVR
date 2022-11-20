using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int Value;
    public bool Negative;
    
    void Start()
    {
        gameObject.transform.localScale = new Vector3(Value, Value, Value);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

    }
}
