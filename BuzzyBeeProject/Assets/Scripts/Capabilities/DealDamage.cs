using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out HealthScript health))
        {
            health.DealDamage(_damage);
            Destroy(gameObject);
        }
    }
}

