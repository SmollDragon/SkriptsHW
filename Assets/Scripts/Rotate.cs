using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        transform.Rotate(_rotateSpeed * Time.deltaTime * Vector3.up);
    }
}
