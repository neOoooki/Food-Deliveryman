using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class Events : SingletonMonoBehaviour<Events>
{
    public UnityEvent SampleEvent;
    private void SampleEventRigister()
    {
        SampleEvent.AddListener(EnergyManager.Instance.SampleCall);
        SampleEvent.AddListener(MoneyManager.Instance.SampleCall);
        SampleEvent.AddListener(StressManager.Instance.SampleCall);
    }

    private void Start()
    {
        SampleEventRigister();
    }
}
