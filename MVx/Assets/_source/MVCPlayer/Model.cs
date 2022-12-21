using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Model 
{
    [SerializeField] private int _health;
    [SerializeField] private int _msxHealth;

    public Action<int> OnHealthChange;
    public Action OnPlayerDeath;
    public Model()
    {
        _health = _msxHealth;
    }
    public void ChangeHealth(int addHealth)
    {
        _health += addHealth;
        OnHealthChange?.Invoke(_health);
        if (_health <= 0)
        {
            OnPlayerDeath?.Invoke();
        }
    }
}
