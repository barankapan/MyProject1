using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje1.Controllers {
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player != null)
            {
                Destroy(this.gameObject);
                Debug.Log("collision var");
            }
        }
    }
}

