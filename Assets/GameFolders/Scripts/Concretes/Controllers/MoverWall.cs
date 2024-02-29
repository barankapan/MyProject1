using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Abstracts.Controllers;
using UdemyProje1.Controllers;
using UnityEngine;


namespace UdemyProje1.Controllers
{
    public class MoverWall :StaticNewWall
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;
        
        Vector3 _startPosition;
        const float _fullCircle = MathF.PI * 2f;
        float _factor;


        private void Awake()
        {   
            _startPosition = transform.position;
        }
        private void Update()

        {
            float cycle = Time.time / _speed;
            float sinWave = MathF.Sin(_fullCircle * cycle);
            _factor = sinWave / 2 + 0.5f;
            //_factor = MathF.Abs(sinWave);
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;




        }
    }

}

