using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loader : MonoBehaviour
{
    public GameObject Loading;

    IEnumerator Post()
    {
        yield return new WaitForSeconds(1);
        Loading.SetActive(false);

    }
    public void ActivaidLader()
    {
        Loading.SetActive(true);
        StartCoroutine(Post());

    }

}
