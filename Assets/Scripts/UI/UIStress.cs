using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStress : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;

    private void Update()
    {
        textMeshProUGUI.text=(StressManager.Instance.Value+=1).ToString();
    }
}
 