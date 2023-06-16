using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindingLinkMonobehaviour : MonoBehaviour
{
    public Vector3 linkPositionA;
    public Vector3 linkPositionB;

    public PathfindingLink GetPathfindingLink()
    {
        return new PathfindingLink
        {
            gridPositionA = LevelGrid.Instance.GetGridPosition(linkPositionA),
            gridPositionB = LevelGrid.Instance.GetGridPosition(linkPositionB)
        };
    }
}
