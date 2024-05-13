using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
