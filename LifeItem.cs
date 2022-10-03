using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeItem : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            if(other.GetComponent<status>().lifeCount < 8){
                other.GetComponent<status>().LifeImage[other.GetComponent<status>().lifeCount].SetActive(true);
                other.GetComponent<status>().lifeCount+=1;
            }
            Destroy(gameObject);
        }
    }
}