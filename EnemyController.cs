using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;

    public int maxHP;
    protected int currentHP;

    public int damage;
    public float attackCooldown = 1f;
    public float lastAttackTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentHP = maxHP;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    protected void Move()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0;

        transform.position += direction.normalized * moveSpeed * Time.deltaTime;
    }

    public virtual void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        PlayerController playerHealth = collision.gameObject.GetComponent<PlayerController>();

    //        if (playerHealth != null)
    //        {
    //            playerHealth.TakeDamage(damage);
    //        }
    //    }
    //}

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        if (Time.time >= lastAttackTime + attackCooldown)
        {
            PlayerController playerHealth = collision.gameObject.GetComponent<PlayerController>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                lastAttackTime = Time.time;
            }
        }
    }
}
