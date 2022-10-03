using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    //ステージ選択画面
    public GameObject GameModeSelect;
    public GameObject StageSelect0;
    public GameObject CharacterSelect1;

    public void GameModeSelected()
    {
        GameModeSelect.SetActive(true);
        StageSelect0.SetActive(false);
    }
    public void StageSelected()
    {
        GameModeSelect.SetActive(false);
        StageSelect0.SetActive(true);
    }
    public void CharacterSelected()
    {
        CharacterSelect1.SetActive(true);
        StageSelect0.SetActive(false);
    }
    public void CharacterSelectreturned()
    {
        CharacterSelect1.SetActive(false);
        StageSelect0.SetActive(true);
    }
}
