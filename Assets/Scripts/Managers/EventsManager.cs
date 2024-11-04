using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EventsManager : SingletonMonoBehaviour<EventsManager>
{
    private void SampleEventTrigger()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Events.Instance.SampleEvent.Invoke();
        }
    }
    private void Update()
    {
        SampleEventTrigger();
    }
}

