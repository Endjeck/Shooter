using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigbody;
    [SerializeField] private float _speed;
    void Update()
    {
        _rigbody.AddForce(transform.forward * _speed *Time.deltaTime);
    }
}
