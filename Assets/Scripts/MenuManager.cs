using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SG
{
    public class MenuManager : MonoBehaviour
    {
        public void PlayingGame()
        {
            SceneManager.LoadScene("Kingdom");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

