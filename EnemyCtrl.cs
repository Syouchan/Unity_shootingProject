using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    [SerializeField] int EnemyHP = 10;
    //public GameoObject DamageEffect;
    public GameObject DeathEffect;
    public GameObject Dropitem;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "syuriken")
        {
            EnemyHP = EnemyHP - 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "kunai")
        {
            EnemyHP = EnemyHP - 2;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Skill")
        {
            EnemyHP = EnemyHP - 20;
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        if (EnemyHP <= 0)
        {
            Instantiate(DeathEffect, this.transform.position, this.transform.rotation);
            Drop();
            Destroy(gameObject);
        }
    }
    void Drop()
    {
        Instantiate(Dropitem, transform.position, transform.rotation);
    }
}
