using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ActionButtonUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] Button button;

    public void SetBaseAction(BaseAction baseAction)
    {
        textMeshProUGUI.text = baseAction.GetActionName().ToUpper();

        button.onClick.AddListener(() =>{
            UnitActionSystem.Instance.SetSelectedAction(baseAction);
        });
    }


}
