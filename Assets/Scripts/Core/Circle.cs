using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private float _gravityScale;
    [SerializeField] private Rigidbody2D _rigidBodyCircle;
    private bool _grounded = true;


    public void ToggleGravity()
    {
        if (!_grounded)
        {
            return;
        }

        _grounded = false;

        if (_rigidBodyCircle.gravityScale >= 0)
        {
            _rigidBodyCircle.gravityScale = -(_gravityScale);
        }
        else
        {
            _rigidBodyCircle.gravityScale = _gravityScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out var ground))
        {
            _grounded = true;
            GameManager.Instance.AddScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
