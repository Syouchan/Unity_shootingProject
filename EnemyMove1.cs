using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove1 : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullet;

    public float speed = 0.05f;

    float time = 0.0f;

    float timeturn2 = 3.0f;

    //int turns = 0;

    //bool turn = false;

    public float cooldown = 0.3f;

    void Update()
    {
        turnmove();
    }
    void turnmove()
    {
        time = Time.time;

        if (timeturn2 - time <= 0)
        {
            timeturn2 += 3;
            speed *= -1;
            Debug.Log("OK");
            //turns++;
        }
        transform.Translate(speed, 0, 0);
        //if (time >= timeturn2 && turn == false)
        //{
        //    turn = true;
        //    transform.Translate(0, 0, -speed);
        //    turns++;
        //}
        //else if (time >= timeturn2 && turn == true)
        //{
        //    turn = false;
        //    transform.Translate(0, 0, -speed);
        //    turns++;
        //}
    }

    //IEnumerator Enemymove()
    //{
    //    while (true)
    //    {
    //        Instantiate(EnemyBullet, transform.position, transform.rotation);
    //        yield return new WaitForSeconds(cooldown);
    //    }
    //}
}
