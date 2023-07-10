using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MobEnemy", menuName = "Mob Enemy")]
public class MobEnemySO : ScriptableObject
{
    public string enemyType;
    public float maxHealth;
    public float health;
    public int attack;
    public int defense;
    public int magic;
    public float energyRate;
    public float evasionRate;

}

