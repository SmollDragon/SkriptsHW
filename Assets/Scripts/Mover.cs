using UnityEngine;

public class Mover : MonoBehaviour
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
        

        if (_isMovingForward)
        {
            transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);

            if (transform.position.x>=_maxDistance)
            {               
                _isMovingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.right * -_moveSpeed * Time.deltaTime);

            if (transform.position.x <= _startPosition.x)
            {               
                _isMovingForward = true;
            }
        }       
    }   
}