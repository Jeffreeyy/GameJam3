using UnityEngine;
using System.Collections;

public class Player1Input : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Timing timing;

    void Awake()
    {
        timing = GetComponent<Timing>();
    }

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
            if (timing._isRed)
                print("P1 got red!");

            else if (!timing._isRed)
                print("P1 Failed");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (timing._isGreen)
                print("P1 got green!");

            else if (!timing._isGreen)
                print("P1 Failed");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (timing._isBlue)
                print("P1 got blue!");

            else if (!timing._isBlue)
                print("P1 Failed");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (timing._isYellow)
                print("P1 got yellow!");

            else if (!timing._isYellow)
                print("P1 Failed");
        }
	}
}
