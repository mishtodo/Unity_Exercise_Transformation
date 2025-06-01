using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        transform.localScale += (Vector3.one * _scalingSpeed * Time.deltaTime);
    }
}