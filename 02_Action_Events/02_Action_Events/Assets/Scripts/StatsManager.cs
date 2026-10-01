using System;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float playerRotation = 1f;

    public static event Action<float, float> playerStatsUpdater;

    private void Start()
    {
        playerStatsUpdater?.Invoke(playerSpeed, playerRotation);
    }
}
