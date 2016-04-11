using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    private Rigidbody2D _rb;
    [SerializeField]
    private Transform _groundChecker;
    private float _jumpForce = 5f;
    private bool _canJump;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (_canJump)
        {
            _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ground")
        {
            _canJump = true;
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        _canJump = false;
    }
}

