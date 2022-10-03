using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//パリィを行うオブジェクトに貼る用
//tag名：paryposision
public class paryArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "paryobj"){
            Destroy(collision.gameObject);
        }
    }
}
