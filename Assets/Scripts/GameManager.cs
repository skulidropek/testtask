using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIComponent _gameDestroyUI;
    private int _expCount;
    private int _expDestroy;
    private Player _player;
    private void Start()
    {
        _gameDestroyUI.gameObject.SetActive(false);
        _expCount = FindObjectsOfType<Exp>().Length;
        _player = FindObjectOfType<Player>();
        _player.OnPlayerPutExp += GameStope;
    }
    
    private void GameStope()
    {
        _expDestroy++;

        if (_expCount <= _expDestroy)
        {
            _gameDestroyUI.gameObject.SetActive(true);
            Destroy(_player.gameObject);
        }
    }

    public void RestartCurrentScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex; 
        SceneManager.LoadScene(currentScene);
    }
}
