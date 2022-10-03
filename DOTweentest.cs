using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweentest : MonoBehaviour
{
    //x.y.z
    
    void Start()
    {
        move1();
    }

    void move1()
    {
        // 2•b‚©‚¯‚Ä(5,0,0)‚ÖˆÚ“®
        this.gameObject.GetComponent<RectTransform>()
            .DOMove(new Vector3(5f, 0f, 0f), 3f)
            .SetEase(Ease.Linear)
            .SetLoops(20, LoopType.Yoyo)
            .SetDelay(2f);
    }
    //void move2()
    //{
    //    Vector3[] path =
    //    {
    //       new Vector3(5f,0f,0f),
    //       new Vector3(0f,-5f,0f),
    //       new Vector3(-5f,0f,0f),
    //       new Vector3(0f,5f,0f)
    //    };
    //    this.gameObject.GetComponent<RectTransform>()
    //        .DOPath(path, 10f);
    //}
}
