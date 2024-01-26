using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;

    private Vector3 _startScale;
    private bool _isGrowing;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        if (_isGrowing)
        {
            transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

            if (transform.lossyScale.magnitude >= _maxScale)
            {
                _isGrowing = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

            if (transform.lossyScale.magnitude <= _startScale.magnitude)
            {
                _isGrowing = true;
            }
        }
    }
}
