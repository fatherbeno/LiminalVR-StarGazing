using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDeactivation : MonoBehaviour
{
    public GameObject self;

    void Start()
    {
        StartCoroutine(Deactivation());
    }

    IEnumerator Deactivation()
    {
        yield return new WaitForSeconds(10);
        self.SetActive(false);
    }
}
