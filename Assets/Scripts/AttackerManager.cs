using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerManager : CharacterManager {

    private int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    private int health;
    public int Health { get { return health; } }

    private bool isAlive;
    public bool IsAlive { get { return isAlive; } }

    [SerializeField] private int defense;
    [SerializeField] private float speed;
    public float Speed { get { return speed; } }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        checkLife();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    void heal()
    {

    }

    void checkLife()
    {
        isAlive = health > 0;
    }
}
