using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�w�i�𓮂����ׂ̃X�N���v�g

public class Scroll : MonoBehaviour
{
    //�w�i�̃X�s�[�h
    [SerializeField] float speed = 30;
    void Update()
    {
        //�f�t�H���g �ォ�牺�ɗ����w�i
        transform.position -= new Vector3(0, Time.deltaTime * speed);
        //Y���W��-11�܂ŗ���΁A12�܂ňړ�����
        if (transform.position.y <= -11f)
        {
            transform.position = new Vector2(0, 12f);
        }

        ////�΂߂ɗ����w�i
        //transform.position -= new Vector3(Time.deltaTime * speed, Time.deltaTime * speed);
        ////Y���W��-11�܂ŗ���΁A12�܂ňړ�����
        //if (transform.position.y <= -15f)
        //{
        //    transform.position = new Vector2(15f, 15f);
        //}
    }
}
