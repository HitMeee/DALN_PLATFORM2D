using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private bool moveLeft = true; // Biến đánh dấu hướng di chuyển

    private void Update()
    {
        // Di chuyển dựa trên biến moveLeft
        if (moveLeft)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            moveLeft = !moveLeft;
            Flip();
        }
    }

    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        // Gán lại Scale mới
        transform.localScale = currentScale;
    }
}