using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAction : BaseAction
{
    float totalSpinAmount;

    private void Update()
    {
        if (!isActive) return;

        float spinAmount = 360 * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, spinAmount, 0);
        totalSpinAmount += spinAmount;

        if(totalSpinAmount > 360f)
        {
            isActive = false;
        }
    }

    public void Spin()
    {
        isActive = true;
        totalSpinAmount = 0f;
    }
}
