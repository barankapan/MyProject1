using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;
namespace UdemyProje1.Uis
{

    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;
        private void Awake()
        {
            if(_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);

            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }
        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}

