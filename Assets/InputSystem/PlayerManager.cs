using Game.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerInput_Actions _input;
    [SerializeField] private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInput_Actions();
        _input.Player.Enable();

        if(_player == null)
        {
            Debug.LogError("Player is NULL!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        _player.CalcutateMovement(_input.Player.Movement.ReadValue<Vector2>());
    }
}
