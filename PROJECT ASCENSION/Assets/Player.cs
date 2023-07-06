using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Base Attributes")]
    [SerializeField] private PlayerAttributes attributes;
    [SerializeField] private float health;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int magic;
    [SerializeField] private float energyRate;
    [SerializeField] private int points;
    [SerializeField] private Abilities[] abilities;

    // Start is called before the first frame update
    void Start()
    {
        health = attributes.health;
        attack = attributes.attack;
        defense = attributes.defense;
        magic = attributes.magic;
        energyRate = attributes.energyRate;
        points = attributes.points;
        abilities = attributes.abilities;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
