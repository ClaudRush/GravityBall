using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localPosition -= new Vector3(Time.deltaTime * _speed, 0);
    }
    public void Init(Vector3 position, float width)
    {
        transform.localScale = new Vector2(width, 0.4f);
        transform.position = position;
    }
}
