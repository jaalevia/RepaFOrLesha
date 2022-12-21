using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Color _highHP;
    [SerializeField] private Color _lowHP;
    [SerializeField] private SpriteRenderer _playerImage;
    [SerializeField] private Button _restart;
    private Text _text;


    public void ViewConstr(Text text, Button restart)
    {
        _text = text;
        _restart = restart;
    }

    public void DeathVisuals()
    {
        _restart.gameObject.SetActive(true);
        _restart.onClick.AddListener(Restart);
    }
    public void UpdateHealthView(int health)
    {
        _text.text = health.ToString();
        if (health > 50)
        {
            _playerImage.color = _highHP;
            
        } else
        {
            _playerImage.color = _lowHP;
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
        
}
