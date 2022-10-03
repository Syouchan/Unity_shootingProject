//“G‚ðˆÚ“®‚³‚¹‚éƒNƒ‰ƒX

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMove2 : MonoBehaviour
{
    Sequence moveSq;

    List<Vector3> path;
    float pathTime;

    public void pathSet(List<Vector3> vectors, float time)
    {
        path = vectors;
        pathTime = time;
        enemyMove();
    }

    private void enemyMove()
    {
        Vector3[] movePath = new Vector3[path.Count];
        for (int i = 0; i < path.Count; i++)
        {
            movePath[i] = transform.position + path[i];
        }

        moveSq = DOTween.Sequence()
            .Append(transform.DOPath(
                movePath,
                pathTime,
                PathType.CatmullRom)
            .SetEase(Ease.Linear))
            .OnComplete(() =>
            {
                Destroy(this.gameObject);
            })
            ;

        moveSq.Play();
    }

    public void SqKill()
    {
        moveSq.Kill();

        Destroy(this.gameObject);
    }
}