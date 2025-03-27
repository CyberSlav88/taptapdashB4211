using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambera : MonoBehaviour
{

    [SerializeField] Transform _player;
    [SerializeField] Vector3 _offset;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _player.position + _offset, 0.1f);
    }
}
