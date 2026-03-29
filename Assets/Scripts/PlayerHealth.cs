using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public DamageFlash damageFlash;
    public GameObject gameOverUI;

    [Header("UI")]
    public Image healthFill;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth < 0)
            currentHealth = 0;

        damageFlash.Flash();

        UpdateHealthUI();

        if (currentHealth == 0)
        {
            GameOver();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        float healthPercent = (float)currentHealth / maxHealth;
        healthFill.transform.localScale = new Vector3(healthPercent, 1, 1);
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}