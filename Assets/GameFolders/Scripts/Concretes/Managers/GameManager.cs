using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProje1.Managers
{

    public class GameManager : SingletonThisObject<GameManager>

    {

        public event System.Action OnGameOver;
        public event System.Action OnGameOut;




        private void Awake()
        {
            SingletonThisGameObject(this);
            
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }

        public void MissionSucceed()
        {
            OnGameOut?.Invoke();
        }
        
        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
            //asenkron 
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(1);
        }
        public void LoadSceneMenu()
        {
            StartCoroutine(LoadSceneMenuAsync());

        }
        private IEnumerator LoadSceneMenuAsync() {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(2);
        }
        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();        }
    }

}

