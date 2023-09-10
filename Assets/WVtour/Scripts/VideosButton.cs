using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VideosButton : MonoBehaviour
{
    private Tour TourObject;
    private loader LoaderObject;

    public GameObject ShowVideoButton;
    public GameObject HideVideoButtons;

    public int VideoNumber;

     Button yourButton;

    private void Start()
    {
        TourObject = FindObjectOfType<Tour>();
        LoaderObject = FindObjectOfType<loader>();

        yourButton = GetComponent<Button>();
        yourButton.onClick.AddListener(ChangeVideo);

    }


    public void ChangeVideo()
    {


        ShowVideoButton.SetActive(true);
        HideVideoButtons.SetActive(false);
        LoaderObject.ActivaidLader();
        TourObject.PlayVideo(VideoNumber);

    }




}
