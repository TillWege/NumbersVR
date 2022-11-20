using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public GameObject TargetArrow, CurrentArrow;
    public ShelfScript SubShelf, AddShelf;

    public int TargetNumber = 0;

    private const float ArrowStepSize = 0.895f;

    void Start()
    {
        System.Random rnd = new System.Random();
        TargetNumber = rnd.Next(-10, 10);
    }

    void Update()
    {
        setTargetArrow();
        setCurrentArrow();

        if((AddShelf.getTotalValue() - SubShelf.getTotalValue()) == TargetNumber)
            Debug.Log("Good job Nerd");
    }

    private void setCurrentArrow()
    {
        Debug.Log("1: " + AddShelf.getTotalValue() + " - 2:" + SubShelf.getTotalValue());
        var Value = AddShelf.getTotalValue() - SubShelf.getTotalValue();
        CurrentArrow.gameObject.transform.localPosition = new Vector3((Value * ArrowStepSize), 0.0f, 0.0f);
    }

    void setTargetArrow()
    {
        TargetArrow.gameObject.transform.localPosition = new Vector3((TargetNumber * ArrowStepSize), 0.0f, 0.0f);
    }
}
