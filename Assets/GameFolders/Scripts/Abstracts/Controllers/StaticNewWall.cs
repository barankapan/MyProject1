using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Controllers;
using UdemyProje1.Managers;
using UnityEngine;

public abstract class StaticNewWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.collider.GetComponent<PlayerController>();
        if (player != null && player.CanMove )
        {
            GameManager.Instance.GameOver();

        }
    }
}
