using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        transform.localScale += (Vector3.one * _scalingSpeed * Time.deltaTime);
        transform.Rotate(Vector3.down * _rotationSpeed * Time.deltaTime);
        transform.position += (Vector3.forward * _speed * Time.deltaTime);
    }
}