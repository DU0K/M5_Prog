using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float speed = 20f;

    void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }
}
