using UnityEngine;


public class EnemyAI : MonoBehaviour
{
    public float speed = 3.5f;
    public int damage = 10;
    public float attackRange = 1.5f;
    private Transform target;
    private bool hasAttacked = false;
    public float health = 30f;
    public int cost = 1;

    [Header("Weapon Drop Settings")]
    [Range(0.1f, 1f)] public float dropChance = 0.2f;
    public GameObject[] weaponPrefabs; // BulletA, B, C, D, E — у порядку
    public static int nextWeaponIndex = 1; // 0 — стартова зброя, наступна — BulletB (індекс 1)

    public void SetTarget(Transform targetTransform)
    {
        target = targetTransform;
    }

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= attackRange)
        {
            Attack();
        }
    }

    void Attack()
    {
        if (hasAttacked) return;
        hasAttacked = true;
        PlayerHealth playerHealth = target.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<GameManager>().points += cost;
        TryDropWeapon();
    }

     void TryDropWeapon()
    {
        // Всі зброї вже відкриті
        if (nextWeaponIndex >= weaponPrefabs.Length) return;

        float roll = Random.value;
        if (roll <= dropChance)
        {
            GameObject weaponDrop = Instantiate(weaponPrefabs[nextWeaponIndex], transform.position + Vector3.up, Quaternion.identity);
            weaponDrop.name = weaponPrefabs[nextWeaponIndex].name;
            nextWeaponIndex++; 
            Debug.Log("Dropped weapon: " + weaponDrop.name);
        }
    }
}
