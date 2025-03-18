using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _jumpForce;

    private Rigidbody _rb;

    private Vector3 _movement;

    private bool _direction;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _direction = true;
    }

    private void Update()
    {
        _movement = transform.forward;
        _rb.MovePosition(transform.position + _movement * _playerSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            _direction = !_direction;

            StartCoroutine(rotate(_direction));
        }
    }

    IEnumerator rotate(bool direction)
    {
        for (int i = 0; i <= 90; i++)
        {
            if (direction)
            {
                transform.localRotation = Quaternion.Euler(transform.localRotation.x, -90 + i, transform.localRotation.z);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(transform.localRotation.x, -i, transform.localRotation.z);
            }

            yield return new WaitForSeconds(0.002f);
        }
    }
}
