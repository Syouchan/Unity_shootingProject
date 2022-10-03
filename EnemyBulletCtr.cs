using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletCtr : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.GetComponent<status>().lifeCount > 0)
            {
                other.GetComponent<status>().lifeCount-=1;
                other.GetComponent<status>().LifeImage[other.GetComponent<status>().lifeCount].SetActive(false);
                other.GetComponent<status>().Lv-=1;
            }
            else
            {
                Debug.Log("ゲームオーバー");
            }
            Destroy(gameObject);
        }
    }
}
