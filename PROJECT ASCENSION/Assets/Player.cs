using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Base Attributes")]
    [SerializeField] private PlayerAttributes attributes;
    public float maxHealth;
    public float health;
    public int attack;
    public int defense;
    public int magic;
    public float energyRate;
    public int points;
    public Abilities[] abilities;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = attributes.maxHealth;
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
    private void FixedUpdate()
    {
        if (Keyboard.current[Key.E].isPressed)
        {
            health -= 10;
            Debug.Log(health);
        }
    }
}
