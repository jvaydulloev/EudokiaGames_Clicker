using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Movement))]
public class Enemy : MonoBehaviour,IDamageable,IMoveble
{

    public static UnityAction OnHealthChanged;

    private Movement _enemyMovement;
   
    public Health EnemyHealth 
    {
        get;
        private set;
    }

    private void Awake()
    {
        _enemyMovement = GetComponent<Movement>();
        
    }

    private void OnEnable()
    {
        Move();
    }

    public void ReviveEnemy(float newHealth) 
    {
        gameObject.SetActive(true);
        EnemyHealth = new Health(newHealth);

    }

    public void ReviveEnemy(float newHealth,float newSpeed)
    {
        gameObject.SetActive(true);
        EnemyHealth = new Health(newHealth);
        _enemyMovement.SetSpeed(newSpeed);
    }

    public void Die() 
    {
        gameObject.SetActive(false);
        GameMode.OnDied?.Invoke();
    }
    public void Move()
    {
        _enemyMovement.StartMoving();
    }

    public void TakingDamage(float damage)
    {
        EnemyHealth.TakeHealth(damage);
        
        if (EnemyHealth.IsDie())
            Die();
        OnHealthChanged?.Invoke();
    }

}
