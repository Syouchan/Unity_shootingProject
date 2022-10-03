using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathAnim : MonoBehaviour
{
    public void OnCompleteAnimation(){
        Destroy(this.gameObject);
    }
}
