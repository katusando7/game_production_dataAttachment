using UnityEngine;

public class ZombieController : EnemyController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        maxHP = 50; // Set the zombie's max HP to 50
        moveSpeed = 2f; // Set the zombie's move speed to 2
        damage = 10; // Set the zombie's damage to 10
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
