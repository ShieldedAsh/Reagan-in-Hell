using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackRange = 1f;
    public int attackDamage = 1;
    public LayerMask enemyLayer;
    public Animator animator;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //play attack animation
           animator.SetBool("Attack", true);
            Attack();
        }
        else
        {
            animator.SetBool("Attack", false);
        }
        
    }

    private void Attack()
    {
        
        // Detect enemies within the attack range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);

        // Damage the enemies
        foreach (Collider2D enemy in hitEnemies)
        {
            Enemy enemyScript = enemy.GetComponent<Enemy>();
            if (enemyScript != null)
            {
                enemyScript.TakeDamage(attackDamage);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Display attack range in the Unity editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
