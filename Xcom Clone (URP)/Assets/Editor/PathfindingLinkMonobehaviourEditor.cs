using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PathfindingLinkMonobehaviour))]
public class PathfindingLinkMonobehaviourEditor : Editor
{
    private void OnSceneGUI()
    {
        PathfindingLinkMonobehaviour pathfindingLinkMonobehaviour = (PathfindingLinkMonobehaviour)target;

        EditorGUI.BeginChangeCheck();
        Vector3 newLinkPositionA = Handles.PositionHandle(pathfindingLinkMonobehaviour.linkPositionA, Quaternion.identity);
        Vector3 newLinkPositionB = Handles.PositionHandle(pathfindingLinkMonobehaviour.linkPositionB, Quaternion.identity);

        if(EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(pathfindingLinkMonobehaviour, "Change Link Position");
            pathfindingLinkMonobehaviour.linkPositionA = newLinkPositionA;
            pathfindingLinkMonobehaviour.linkPositionB = newLinkPositionB;
        }
    }
}
