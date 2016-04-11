using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    private Rigidbody2D _rb;
    [SerializeField]
    private float _jumpForce = 5f;
    private bool _isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if(_isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
        _isGrounded = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll != null)
        {
            _isGrounded = true;
        }
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        _isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        _isGrounded = false;
    }
}

