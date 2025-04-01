<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambera : MonoBehaviour
{

=======
using UnityEngine;

public class CameraController : MonoBehaviour
{
>>>>>>> db03b34afc2ac6524bec214cc80f16581decec58
    [SerializeField] Transform _player;
    [SerializeField] Vector3 _offset;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _player.position + _offset, 0.1f);
    }
}
