using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private PlayerMovmentModel _playerMovmentModel;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        _playerMovmentModel.ChangeVector(x, y);
    }
    public void InputListenerConstructor(PlayerMovmentModel playerMovmentModel)
    {
        _playerMovmentModel = playerMovmentModel;

    }
}
