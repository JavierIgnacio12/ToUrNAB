using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CreateVideoButton))]
public class CustomVideoButton : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        CreateVideoButton ObjectCreateVideoButton = (CreateVideoButton)target;

        if (GUILayout.Button("Create Button For Next Video"))
        {
            ObjectCreateVideoButton.CreateNextButtonForVideo();

        }
    }
}
