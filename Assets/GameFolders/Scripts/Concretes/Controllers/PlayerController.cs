using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Inputs;
using UdemyProje1.Managers;
using UdemyProje1.Movements;
using UnityEngine;

namespace UdemyProje1.Controllers {
    public class PlayerController : MonoBehaviour

    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;
        
        DefaultInput _input;
        bool _isForceUp;
        Mover _mover;
        Rotator _rotator;
        float _leftRight;
        Fuel _fuel;
        bool _canMove;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        public bool CanMove => _canMove;

        private void Awake()
        {

            _input = new DefaultInput();
            _mover = new Mover (playerController: this);
            _rotator= new Rotator(playerController: this);
            _fuel= GetComponent<Fuel>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTriggered;
            GameManager.Instance.OnGameOut += HandleOnEventTriggered;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
            GameManager.Instance.OnGameOut -= HandleOnEventTriggered;   
        }

        private void Update()
        {
            if (!_canMove )
                return;
            if (_input.IsForceUp && !_fuel.IsEmpty) { 
                _isForceUp = true;
            }
            else   { 
                _isForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }
         _leftRight = _input.LeftRight;
        }
        private void FixedUpdate()
        {
            if ( _isForceUp )
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            _rotator.FixedTick(_leftRight);
        }
        private void HandleOnEventTriggered()
        {
            _canMove= false;
            _isForceUp= false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }
}


