using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;

namespace UdemyProje1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked() {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClicked() {
            GameManager.Instance.LoadSceneMenu();
        }
    }

}

