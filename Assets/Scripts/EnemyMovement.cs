using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;             // Enemy movement speed
    public float leftBoundary = -5f;     // Left boundary position
    public float rightBoundary = 5f;     // Right boundary position

    private bool movingRight = true;     // Flag indicating the direction of movement
    public Animator animator;

    private void Update()
    {
        if (movingRight)
        {
            // Move the enemy to the right
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            // Check if the enemy has reached the right boundary
            if (transform.position.x >= rightBoundary)
            {
                // Change direction
                movingRight = false;
                // Flip the enemy sprite horizontally
                FlipSprite();
            }
        }
        else
        {
            // Move the enemy to the left
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            // Check if the enemy has reached the left boundary
            if (transform.position.x <= leftBoundary)
            {
                // Change direction
                movingRight = true;
                // Flip the enemy sprite horizontally
                FlipSprite();
            }
        }
    }

    private void FlipSprite()
    {
        // Flip the enemy's sprite horizontally
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
