using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillItem : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<status>().skill < 8)
            {
                other.GetComponent<status>().SkillImage[other.GetComponent<status>().skill].SetActive(true);
                other.GetComponent<status>().skill += 1;
            }
            Destroy(gameObject);
        }
    }
}
