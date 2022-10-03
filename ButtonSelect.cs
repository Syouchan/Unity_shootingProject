using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    //ÉÅÉCÉìÉÅÉjÉÖÅ[àÍóó
    public GameObject MainMenu;
    public GameObject GameSelect;
    public GameObject Manual;
    public GameObject MusicRoom;
    public GameObject Option;

    public void Gameselected()
    {
        MainMenu.SetActive(false);
        GameSelect.SetActive(true);//Å©
        Manual.SetActive(false);
        MusicRoom.SetActive(false);
        Option.SetActive(false);
    }
    public void ManualSelected()
    {
        MainMenu.SetActive(false);
        GameSelect.SetActive(false);
        Manual.SetActive(true);//Å©
        MusicRoom.SetActive(false);
        Option.SetActive(false);
    }
    public void MusicRoomSelected()
    {
        MainMenu.SetActive(false);
        GameSelect.SetActive(false);
        Manual.SetActive(false);
        MusicRoom.SetActive(true);//Å©
        Option.SetActive(false);
    }
    public void OptionSelected()
    {
        MainMenu.SetActive(false);
        GameSelect.SetActive(false);
        Manual.SetActive(false);
        MusicRoom.SetActive(false);
        Option.SetActive(true);//Å©
    }
    public void MainMenuSelected()
    {
        MainMenu.SetActive(true);//Å©
        GameSelect.SetActive(false);
        Manual.SetActive(false);
        MusicRoom.SetActive(false);
        Option.SetActive(false);
    }
}
