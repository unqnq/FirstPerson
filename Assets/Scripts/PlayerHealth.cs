using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public TextMeshProUGUI healthText;
    public GameObject gameOverPanel;

    private void Start()
    {
        currentHealth = maxHealth;
        gameOverPanel.SetActive(false); // Сховати панель Game Over на початку
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        // Debug.Log("Player took damage: " + amount + ", health left: " + currentHealth);

        healthText.text = "HP:" + currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameOverPanel.SetActive(true); // Відображаємо панель Game Over
        Cursor.lockState = CursorLockMode.None; // Відкриваємо курсор
        Cursor.visible = true;
        FindAnyObjectByType<EnemySpawner>().canSpawn = false; // Зупиняємо спавн ворогів
    }
}

