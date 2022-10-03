using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualButton : MonoBehaviour
{
    public GameObject Chara1Manual;
    public GameObject Chara2Manual;
    public GameObject Chara3Manual;
    public GameObject itemManual;
    public void Chara1Selected()
    {
        Chara1Manual.SetActive(true);
        Chara2Manual.SetActive(false);
        Chara3Manual.SetActive(false);
        itemManual.SetActive(false);
    }
    public void Chara2Selected()
    {
        Chara1Manual.SetActive(false);
        Chara2Manual.SetActive(true);
        Chara3Manual.SetActive(false);
        itemManual.SetActive(false);
    }
    public void Chara3Seleted()
    {
        Chara1Manual.SetActive(false);
        Chara2Manual.SetActive(false);
        Chara3Manual.SetActive(true);
        itemManual.SetActive(false);
    }
    public void itemSelected()
    {
        Chara1Manual.SetActive(false);
        Chara2Manual.SetActive(false);
        Chara3Manual.SetActive(false);
        itemManual.SetActive(true);
    }
}
