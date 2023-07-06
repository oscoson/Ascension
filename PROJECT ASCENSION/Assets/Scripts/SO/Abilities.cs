using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Abilities : ScriptableObject
{
    public string abilityName;
    public float damage;
    public int speed;
    public Sprite abilitySprite;
}
