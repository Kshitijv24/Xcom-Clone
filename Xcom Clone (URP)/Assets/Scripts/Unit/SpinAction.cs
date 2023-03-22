using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinAction : BaseAction
{
    float totalSpinAmount;

    private void Update()
    {
        if (!isActive) return;

        float spinAmount = 360 * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, spinAmount, 0);
        totalSpinAmount += spinAmount;

        if (totalSpinAmount > 360f)
        {
            isActive = false;
            onActionComplete();
        }
    }

    public override void TakeAction(GridPosition gridPosition, Action onActionComplete)
    {
        this.onActionComplete = onActionComplete;
        isActive = true;
        totalSpinAmount = 0f;
    }

    public override string GetActionName()
    {
        return "Spin";
    }

    public override List<GridPosition> GetValidActionGridPositionList()
    {
        List<GridPosition> validGridPositionList = new List<GridPosition>();
        GridPosition unitGridPosition = unit.GetGridPosition();

        return new List<GridPosition> { unitGridPosition };
    }
}
