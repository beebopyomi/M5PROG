using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action<int> ScoreAdd;
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            System.Random random = new System.Random();
            int points = random.Next(0, 500000000);
            ScoreAdd?.Invoke(points);
            Destroy(gameObject);
        }
    }
}