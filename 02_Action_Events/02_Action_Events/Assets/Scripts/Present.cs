using System;
using UnityEngine;

public class Present : MonoBehaviour
{
    [SerializeField] private int presentValue = 100;

    public static event Action<int> scoreUpdater;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UpdateScore();
        }
    }
    private void UpdateScore()
    {
        scoreUpdater?.Invoke(presentValue);
    }
}
