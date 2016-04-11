using UnityEngine;
using System.Collections;

public class Player1Input : MonoBehaviour
{
    private ChunkManager _cm;
    private PlayerMovement _playerMovement;
    private Timing timing;
    private float _addedChunkSpeed = 0.5f;

    void Awake()
    {
        timing = GetComponent<Timing>();
    }

	// Use this for initialization
	void Start () 
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _cm = GameObject.Find("ChunkManager").GetComponent<ChunkManager>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Player 1
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (timing._isRed)
            {
                print("P1 got red!");
                _cm.chunkSpeed += _addedChunkSpeed;
                timing._isRed = false;
            }

            else if (!timing._isRed)
            {
                print("P1 Failed");
                _cm.chunkSpeed -= _addedChunkSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (timing._isGreen)
            {
                print("P1 got green!");
                _cm.chunkSpeed += _addedChunkSpeed;
                timing._isGreen = false;
            }
            else if (!timing._isGreen)
            {
                print("P1 Failed");
                _cm.chunkSpeed -= _addedChunkSpeed;
            }    
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (timing._isBlue)
            {
                print("P1 got blue!");
                _cm.chunkSpeed += _addedChunkSpeed;
                timing._isBlue = false;
            }
            else if (!timing._isBlue)
            {
                print("P1 Failed");
                _cm.chunkSpeed -= _addedChunkSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (timing._isYellow)
            {
                print("P1 got yellow!");
                _cm.chunkSpeed += _addedChunkSpeed;
                timing._isYellow = false;
            }
            else if (!timing._isYellow)
            {
                print("P1 Failed");
                _cm.chunkSpeed -= _addedChunkSpeed;
            }    
        }
	}
}
