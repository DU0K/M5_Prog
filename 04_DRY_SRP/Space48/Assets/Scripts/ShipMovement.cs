using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;

    public float RotationSpeed
    {
        get => rotationSpeed;
        set => rotationSpeed = value;
    }

    void Update()
    {;
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}