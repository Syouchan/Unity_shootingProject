using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//背景を動かす為のスクリプト

public class Scroll : MonoBehaviour
{
    //背景のスピード
    [SerializeField] float speed = 30;
    void Update()
    {
        //デフォルト 上から下に流れる背景
        transform.position -= new Vector3(0, Time.deltaTime * speed);
        //Y座標が-11まで来れば、12まで移動する
        if (transform.position.y <= -11f)
        {
            transform.position = new Vector2(0, 12f);
        }

        ////斜めに流れる背景
        //transform.position -= new Vector3(Time.deltaTime * speed, Time.deltaTime * speed);
        ////Y座標が-11まで来れば、12まで移動する
        //if (transform.position.y <= -15f)
        //{
        //    transform.position = new Vector2(15f, 15f);
        //}
    }
}
