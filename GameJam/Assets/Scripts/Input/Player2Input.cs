using UnityEngine;
using System.Collections;

public class Player2Input : MonoBehaviour 
{
    private PlayerMovement _playerMovement;

    // Use this for initialization
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Player 2
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _playerMovement.Jump();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //
        }
	}
}
