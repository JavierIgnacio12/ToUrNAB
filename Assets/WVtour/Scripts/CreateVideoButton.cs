using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateVideoButton : MonoBehaviour
{
    public GameObject VideoButton;
    public GameObject HideButtonGroup;
    public GameObject ShowButtonGroup;
    public int ButtonForVideoNumber = 0;
    public Vector3 ButtonPosition;

    public void CreateNextButtonForVideo()
    {

        var i = Instantiate(VideoButton, ButtonPosition, Quaternion.identity);

        i.transform.parent = gameObject.transform;
        i.name = "Button for next Video ID: " + ButtonForVideoNumber;
        VideosButton CreateNewScriptOfVideoButtonForButton = new VideosButton();
        CreateNewScriptOfVideoButtonForButton = i.AddComponent<VideosButton>();
        CreateNewScriptOfVideoButtonForButton.VideoNumber = ButtonForVideoNumber;
        CreateNewScriptOfVideoButtonForButton.ShowVideoButton = ShowButtonGroup;
        CreateNewScriptOfVideoButtonForButton.HideVideoButtons = HideButtonGroup;

    }
}
