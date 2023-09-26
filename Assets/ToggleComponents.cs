using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

    public class ToggleComponents : MonoBehaviour
    {
    public UnityEvent m_Event_activate;
    public UnityEvent m_Event_deactivate;
    void invoke_events_activate()
    {
        m_Event_activate.Invoke();
        Debug.Log("Animazione terminata e azioni eseguite!!");
    }
    void invoke_events_deactivate()
    {
        m_Event_deactivate.Invoke();
        Debug.Log("Animazione terminata e azioni eseguite!!");
    }
}


