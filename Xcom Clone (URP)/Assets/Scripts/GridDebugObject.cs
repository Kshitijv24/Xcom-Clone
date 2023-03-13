using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] TextMeshPro textMeshPro;

    GridObject gridObject;

    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
    }

    private void Update()
    {
        textMeshPro.text = gridObject.ToString();
    }
}
