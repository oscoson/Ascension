using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Image healthBar;
    public Image secondaryHealthBar;
    public Enemy enemy;
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private Transform healthBarPosition; 
    [SerializeField] private Vector3 offset;


    private void Start()
    {
    }

    private void Update()
    {
        currentHealth = enemy.health; // current health starts and updates with the player's health
        maxHealth = enemy.maxHealth; // max health starts and updates with the player's max health
        healthBar.fillAmount = currentHealth / enemy.maxHealth;
        healthBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

    }

    private void FixedUpdate()
    {
        if (secondaryHealthBar.fillAmount > healthBar.fillAmount)
        {
            secondaryHealthBar.fillAmount -= 0.01f;
        }
        // else match it with primary health bar
    }
}
