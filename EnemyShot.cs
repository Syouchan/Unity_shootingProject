using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    //発射位置になるオブジェクト指定
    public GameObject enebullposition;
    public float bulletSpeed = 10.0f;

    void Start()
    {
        //transform.LookAt(player.transform);
        StartCoroutine("BallShot");
    }

    void Update()
    {
        //transform.LookAt(player.transform);
        //Vector3 diff = (player.gameObject.transform.position - this.transform.position);
        //this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
    }

    IEnumerator BallShot()
    {
        while (true)
        {
            var shot = Instantiate(bullet, enebullposition.transform.position, Quaternion.identity);
            shot.GetComponent<Rigidbody2D>().velocity = transform.forward.normalized * bulletSpeed;
            yield return new WaitForSeconds(1.0f);
        }
    }
}