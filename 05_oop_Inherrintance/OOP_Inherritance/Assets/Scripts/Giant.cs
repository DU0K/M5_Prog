using UnityEngine;

public class Giant : Enemy
{
    [SerializeField] private int speed = 5;
    private void Update()
    {
        Walk(speed);
    }
}
