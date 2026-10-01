using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    private InputActionMap player;
    private InputAction move;
    private InputAction look;

    private float moveSpeed = 10f;
    private float rotationSpeed = 1f;

    private void Awake()
    {
        player = inputActions.FindActionMap("Player");
        move = player.FindAction("Move");
        look = player.FindAction("Look");
    }
    private void OnEnable()
    {
        player.Enable();
        StatsManager.playerStatsUpdater += UpdateStats;
    }
    private void OnDisable()
    {
        player.Disable();
        StatsManager.playerStatsUpdater -= UpdateStats;
    }

    private void Update()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        transform.position += new Vector3(move.ReadValue<Vector2>().x * Time.deltaTime * moveSpeed, 0, move.ReadValue<Vector2>().y * Time.deltaTime * moveSpeed);
    }
    private void Rotation()
    {
        float rotationX = look.ReadValue<Vector2>().x * Time.deltaTime * rotationSpeed;
        float rotationY = -look.ReadValue<Vector2>().y * Time.deltaTime * rotationSpeed;
        float rotationYClamped = Mathf.Clamp(rotationY, -45f, 45f);
        transform.Rotate(0, rotationX, 0f);
    }
    private void UpdateStats(float _moveSpeed, float _rotationSpeed)
    {
        moveSpeed = _moveSpeed;
        rotationSpeed = _rotationSpeed;
    }
}
