using UnityEngine;
using System.Collections;

public class Player1Input : MonoBehaviour 
{
    private PlayerMovement _playerMovement;

	// Use this for initialization
	void Start () 
    {
        _playerMovement = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Player 1
        if (Input.GetKeyDown(KeyCode.W))
        {
            _playerMovement.Jump();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //
        }
	}
}
