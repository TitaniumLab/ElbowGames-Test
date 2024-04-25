using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ElbowGames.Input
{
    [RequireComponent(typeof(PlayerInput))]
    public class MobileInput : MonoBehaviour, IHorizontalInput, IVerticalInput
    {
        private PlayerInput _playerInput;
        [SerializeField] private float _xInput;
        [SerializeField] private float _yInput;

        public event Action<float> OnHorizontalInput;
        public event Action<float> OnVerticalInput;


        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
        }


        private void Update()
        {
            _xInput = _playerInput.actions["Move"].ReadValue<Vector2>().x;
            _yInput = _playerInput.actions["Move"].ReadValue<Vector2>().y;

            if (_xInput != 0)
                OnHorizontalInput?.Invoke(_xInput);
            if (_yInput != 0)
                OnVerticalInput?.Invoke(_yInput);
        }
    }
}
