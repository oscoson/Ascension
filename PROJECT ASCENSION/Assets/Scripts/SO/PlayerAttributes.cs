using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Character", menuName = "Player")]
public class PlayerAttributes : ScriptableObject
{
    public float maxHealth;
    public float health;
    public int attack;
    public int defense;
    public int magic;
    public float energyRate;
    public float evasionRate;
    public int points;
    public Abilities[] abilities;
}
