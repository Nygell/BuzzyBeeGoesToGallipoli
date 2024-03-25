using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private float _attackSpeed;
    [SerializeField]
    private GameObject _projectile, _firingPoint;
    private InputManager _inputManager;

    void Awake()
    {
        _inputManager = GetComponent<InputManager>();
    }

    private void Start()
    {
        StartCoroutine(FiringCoroutine());
    }

    IEnumerator FiringCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(_attackSpeed);
            if (_inputManager.Controller.RetrieveFiringInput())
            {
                Instantiate(_projectile, _firingPoint.transform.position, Quaternion.identity);
            }
        }
    }
}
