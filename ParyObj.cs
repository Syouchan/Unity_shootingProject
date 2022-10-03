using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//パリィができるオブジェクトに貼り付ける用
//tag名：paryobj
public class ParyObj : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "paryposision"){
            Destroy(this.gameObject);
        }
    }
}
