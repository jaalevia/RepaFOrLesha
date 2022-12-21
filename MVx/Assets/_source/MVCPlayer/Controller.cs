using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private Model _model;
    private View _view;
    private PlayerMovmentController _playerMovmentController;

    public Controller(Model model, View view, PlayerMovmentController playerMovmentController)
    {
        _model = model;
        _view = view;
        _playerMovmentController = playerMovmentController;
        Bind();
        _model.ChangeHealth(0);
    }

    private void Bind()
    {
        _playerModel.OnHealthChange += OnHealthChanged;
        _playerModel.OnPlayerDeath += OnDeath;
    }
    private void Expose()
    {
        _playerModel.OnHealthChange -= OnHealthChanged;
        _playerModel.OnPlayerDeath -= OnDeath;
    }
    private void OnHealthChanged(int health) => _playerView.UpdateHealthView(health);
    private void OnDeath()
    {
        _playerView.ShowPlayerDeath();
        Expose();
        _playerMovementController.Expose();
    }
}
