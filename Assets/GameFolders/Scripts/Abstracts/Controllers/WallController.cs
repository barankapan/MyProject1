using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Controllers;
using UdemyProje1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProje1.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player != null && !player.CanMove)
            {
                GameManager.Instance.GameOver();
               
            }
        }
    }

}
