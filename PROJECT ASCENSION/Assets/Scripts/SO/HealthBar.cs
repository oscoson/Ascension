using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public Image secondaryHealthBar;
    public Player player;
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private Transform healthBarPosition; 
    [SerializeField] private Vector3 offset;


    private void Start()
    {
    }

    private void Update()
    {
        currentHealth = player.health; // current health starts and updates with the player's health
        maxHealth = player.maxHealth; // max health starts and updates with the player's max health
        healthBar.fillAmount = currentHealth / player.maxHealth;
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