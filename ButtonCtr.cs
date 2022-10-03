using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonCtr : MonoBehaviour
{
    public Button MainMenuFirstSelectButton;
    bool GameSelect = false;
    void Start()
    {
        if (GameSelect == false )
        {
            MainMenuFirstSelectButton.Select();
        }
        Debug.Log(GameSelect);
    }

    public void GameSelectOn()
    {
        GameSelect = true;
        Debug.Log(GameSelect);
    }
}
