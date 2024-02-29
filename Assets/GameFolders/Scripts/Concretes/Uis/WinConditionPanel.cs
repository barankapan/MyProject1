using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Managers;
using UnityEngine;

namespace UdemyProje1.Uis
{

    public class WinConditionPanel : MonoBehaviour
    {
       public void YesClicked ()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

    }

}

