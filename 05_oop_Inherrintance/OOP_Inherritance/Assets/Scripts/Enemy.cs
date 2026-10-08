using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    protected int lives;
    private int damage = 1;

    private int currentPoint = 0;
    protected void Walk(int speed)
    {
        if (points == null || points.Length == 0) return;
        Transform targetPoint = points[currentPoint];
        float newX = Mathf.MoveTowards(transform.position.x, targetPoint.position.x, speed * Time.deltaTime);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        if (Mathf.Abs(transform.position.x - targetPoint.position.x) < 2f)
        {
            currentPoint++;

            if (currentPoint >= points.Length)
            {
                currentPoint = 0;
            }
        }
    }

    protected void TakeDamage()
    {
        lives -= damage;
        if (lives <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            TakeDamage();
        }
    }
}
