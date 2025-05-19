using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] private BulletMover _bulletMover;
    [SerializeField] private float _firerate = 2;
    [SerializeField] private Transform _bulletStart;
    void Start()
    {
        StartCoroutine(shoot());
    }

    private IEnumerator shoot()
    {
        while (true)
        {
            Instantiate(_bulletMover, _bulletStart.position, _bulletStart.rotation);
            yield return new WaitForSeconds(_firerate);
        }
    }
}
