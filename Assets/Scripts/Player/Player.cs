using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public static UnityAction<GameObject> OnClicked;
    [SerializeField] private float _damage = 10;

    private void OnEnable()
    {
        OnClicked += Damage;
    }

    private void OnDisable()
    {
        OnClicked -= Damage;
    }
    private void Damage(GameObject enemy) 
    {
        enemy.GetComponent<Enemy>().TakingDamage(_damage);
    }
}
