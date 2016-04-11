using UnityEngine;
using System.Collections;

public class Player2Input : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Timing timing;

    void Awake()
    {
        timing = GetComponent<Timing>();
    }

    // Use this for initialization
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player 2
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (timing._isRed)
                print("P2 got red!");

            else if (!timing._isRed)
                print("P2 Failed");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (timing._isGreen)
                print("P2 got green!");

            else if (!timing._isGreen)
                print("P2 Failed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (timing._isBlue)
                print("P2 got blue!");

            else if (!timing._isBlue)
                print("P2 Failed");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (timing._isYellow)
                print("P2 got yellow!");

            else if (!timing._isYellow)
                print("P2 Failed");
        }
    }
}
