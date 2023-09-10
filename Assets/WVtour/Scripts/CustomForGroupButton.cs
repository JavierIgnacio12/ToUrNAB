using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CreateGroupButton))]
public class CustomForGroupButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CreateGroupButton ObjectForCreateGroupButton = (CreateGroupButton)target;
        if (GUILayout.Button("Create Group Button"))
        {
            ObjectForCreateGroupButton.CreateGroupButtonHolder();
        }
    }
}
