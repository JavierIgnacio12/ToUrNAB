using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGroupButton : MonoBehaviour
{
    public GameObject GroupButton;
    public GameObject HideButtonGroup;
    int GroupButtonNumber = 0;
    Vector3 spawnHere;

    public void CreateGroupButtonHolder()
    {

        var i = Instantiate(GroupButton, spawnHere, Quaternion.identity);
        i.transform.parent = gameObject.transform;
        GroupButtonNumber = GameObject.FindGameObjectsWithTag("GroupButtonHolder").Length - 1;
        i.name = "Group Button For Video ID: " + GroupButtonNumber;


    }
}
