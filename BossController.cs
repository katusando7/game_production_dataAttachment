using UnityEngine;

public class BossController : EnemyController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        moveSpeed = 1f; // Set the boss's move speed to 1
        maxHP = 200; // Set the boss's max HP to 200
        damage = 20; // Set the boss's damage to 20
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        Skill();
    }

    void Skill()
    {

    }
}
