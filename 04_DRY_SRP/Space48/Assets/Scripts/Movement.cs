using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public bool usePlayerInput = false;
    float inputMultiplier;
    void Update()
    {
        
        if (usePlayerInput)
        {
            inputMultiplier = Input.GetAxis("Vertical");
        }
        transform.position += transform.forward * moveSpeed * inputMultiplier * Time.deltaTime;
    }
}
