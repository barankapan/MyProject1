using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;

namespace UdemyProje1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }

}

