using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "syuriken" || collision.tag == "kunai" 
            || collision.tag == "enemybullet" || collision.tag == "enemy"
            || collision.tag == "lifeitem" || collision.tag == "ultitem"
            || collision.tag == "Poweritem" || collision.tag == "MAXultitem"
            || collision.tag == "MAXpoweritem" || collision.tag == "lifePeace")
        {
            Destroy(collision.gameObject);
        }
    }
}
