using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentController 
{
    private PlayerMovmentModel _playerMovmentModel;
    private MovementView _movementView;
    public PlayerMovmentController(PlayerMovmentModel playerMovmentModel, MovementView movementView)
    {
        _playerMovmentModel = playerMovmentModel;
        _movementView = movementView;
        Bind();
    }

    public void Bind()
    {
        _playerMovmentModel.OnVectorChange += OnChangeVector;
    }
    public void Expose()
    {
        _playerMovmentModel.OnVectorChange -= OnChangeVector;
    }
    private void OnChangeVector(Vector2 newVector) => _movementView.UpdatePlayerView(newVector);
}
