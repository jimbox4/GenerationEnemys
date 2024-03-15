using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _speed;
    }
}
