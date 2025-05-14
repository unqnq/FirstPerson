using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f;
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime); // самознищення через час
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyAI enemy = other.GetComponent<EnemyAI>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject); // куля зникає
                // Debug.Log("Bullet hit enemy!");
            }
        }

    }
}
