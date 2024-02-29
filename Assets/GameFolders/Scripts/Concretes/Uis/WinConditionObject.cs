using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;

namespace UdemyProje1.Uis
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionPanel;

        private void Awake()
        {
            if (_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOut += HandleOnMissionSucceed;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOut -= HandleOnMissionSucceed;
        }
        private void HandleOnMissionSucceed()
        {
            if (!_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(true);
            }
        }
    }
    
}

