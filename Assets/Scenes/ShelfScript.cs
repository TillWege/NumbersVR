using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    public bool negative_shelf = false;
    private List<BallScript> Balls;

    void Start()
    {
        Debug.Log("Creating List...");
        Balls = new List<BallScript>();
    }


    void OnCollisionEnter(Collision collision)
    {
        BallScript ball = collision.gameObject.GetComponent(typeof(BallScript)) as BallScript;

        if (!Balls.Contains(ball)){
            Balls.Add(ball);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        BallScript ball = collision.gameObject.GetComponent(typeof(BallScript)) as BallScript;

        if (Balls.Contains(ball)){
            Balls.Remove(ball);
        }
    }

    public int getTotalValue() {
        int result = 0;

        foreach (BallScript ball in Balls) {
            if (negative_shelf) {
                if(ball.Negative){
                    result -= ball.Value;
                } else {
                    result += ball.Value;
                }
            } else {                
                if(ball.Negative){
                    result -= ball.Value;
                } else {
                    result += ball.Value;
                }
            }
        }
        return result;
    }
}
