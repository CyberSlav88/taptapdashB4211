using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Vector3 _offset;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _player.position + _offset, 0.1f);
    }
}
