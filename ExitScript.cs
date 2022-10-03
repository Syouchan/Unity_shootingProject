using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成日/02/08
//アプリを終了するためのスクリプト
public class ExitScript : MonoBehaviour
{
    public void ExitButton()
    {
        Debug.Log("終了ログ");
        
        Application.Quit();
    }
}
