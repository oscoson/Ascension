using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    // Slime specific actions here
    [SerializeField] private string slimeType;

    // Start is called before the first frame update
    void Start()
    {
        slimeType = enemy.enemyType;
        maxHealth = enemy.maxHealth;
        health = enemy.health;
        attack = enemy.attack;
        defense = enemy.defense;
        magic = enemy.magic;
        energyRate = enemy.energyRate;
        evasionRate = enemy.evasionRate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
