using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _maxDistance;

    private Vector3 _startPosition;
    private bool _isMovingForward;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        Vector3 position = transform.position;

        if (_isMovingForward)
        {
            position.x += _moveSpeed * Time.deltaTime;

            if (position.x >= _maxDistance)
            {
                position.x = _maxDistance;

                _isMovingForward = false;
            }
        }
        else
        {
            position.x -= _moveSpeed * Time.deltaTime;

            if (position.x <= _startPosition.x)
            {
                position.x = _startPosition.x;
                _isMovingForward = true;
            }
        }

        transform.position = position;
    }   
}