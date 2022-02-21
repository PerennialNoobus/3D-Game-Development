using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth;
    public Image healthBar;

    private float currentHealth = 0;

    //Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= amount;
            Debug.Log("Current health is now " + currentHealth);
            if (currentHealth == 0)
            {
                currentHealth = 0;
                Debug.Log("We dead."); //Logs a death message if currentHealth is equal to 0
            }
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}