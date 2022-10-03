using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolCtrl : MonoBehaviour
{
    public GameObject poolObject;
    public List<GameObject> listOfPooledObj = new List<GameObject>();

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(poolObject,this.transform);
            obj.SetActive(false);
            listOfPooledObj.Add(obj);
        }
    }
    public GameObject GetPooledObj()
    {
        for(int i = 0; i < listOfPooledObj.Count; i++)
        {
            if (listOfPooledObj[i].activeInHierarchy == false)
            {
                return listOfPooledObj[i];
            }
        }
        return null;
    }
}
