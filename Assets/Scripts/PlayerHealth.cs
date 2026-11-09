using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHelath = 100;
    [SerializeField] private int startingHealth = 50;
    [SerializeField] private TextMeshProUGUI healthText;

    private int currentHealth;

    void Start()
    {
        currentHealth = Mathf.Clamp(startingHealth, 0, maxHelath);
        UpdateHealthText();
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHelath)
        {
            currentHealth = maxHelath;
        }

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "HP " + currentHealth + "/" + maxHelath;
    }
}
