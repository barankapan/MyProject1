using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProje1.Controllers {
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWorks;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController playerController = other.collider.GetComponent<PlayerController>();
            if (playerController == null || !playerController.CanMove)
            
                return;
                if (other.GetContact(0).normal.y == -1) { 
                    _finishFireWorks.gameObject.SetActive(true);
                    _finishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucceed();

                }
                else
                {
                GameManager.Instance.GameOver();
                }
            }
        

    }
}

