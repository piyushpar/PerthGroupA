using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))] 

public class RocketMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _Joystick;

    [SerializeField] private float _moveSpeed;

    public void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_Joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _Joystick.Vertical * _moveSpeed);

        if (_Joystick.Horizontal != 0 || _Joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }

}
