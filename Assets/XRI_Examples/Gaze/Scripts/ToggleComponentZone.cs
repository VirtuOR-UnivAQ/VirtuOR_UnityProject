using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

    public class ToggleComponentZone : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Main Trigger Volume to detect the Activation Object within. Must be on same physics layer as the Activation Object.")]
        Collider m_TriggerVolume;

        /// <summary>
        /// Main Trigger Volume to detect the Activation Object within.
        /// Must be on same physics layer as the Activation Object.
        /// </summary>
        public Collider triggerVolume
        {
            get => m_TriggerVolume;
            set => m_TriggerVolume = value;
        }

        [SerializeField]
        [Tooltip("Collider that will trigger the component to turn on or off when entering the Trigger Volume. Must have a Rigidbody component and be on the same physics layer as the Trigger Volume.")]
        Collider m_ActivationObject;

        /// <summary>
        /// Collider that will trigger the component to turn on or off when entering the Trigger Volume.
        /// Must have a Rigidbody component and be on the same physics layer as the Trigger Volume.
        /// </summary>
        public Collider activationObject
        {
            get => m_ActivationObject;
            set => m_ActivationObject = value;
        }

        [SerializeField]
        [Tooltip("GameObject to set the enabled state for. Will set the value to the Enable On Entry value upon entry and revert to original value on exit.")]
        List<GameObject> m_ObjectToToggle;

    public UnityEvent onEnterEvent;
    public UnityEvent onExitEvent;
    
        void Start()
        {
            if (m_TriggerVolume == null && !TryGetComponent(out m_TriggerVolume))
            {
                enabled = false;
                return;
            }

            if (!m_TriggerVolume.isTrigger)
                m_TriggerVolume.isTrigger = true;
        }

    void OnTriggerEnter(Collider other)
        {
            if (other != null && other == m_ActivationObject)
            {
                Debug.Log("collisione");
                
                foreach (var item in m_ObjectToToggle)
                {
                    item.SetActive(true);
                }

                onEnterEvent.Invoke();
                Debug.Log("ho attivato tutto");

            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other != null && other == m_ActivationObject)
            {
                foreach (var item in m_ObjectToToggle)
                {
                    item.SetActive(false);
                }
                onExitEvent.Invoke();
                Debug.Log("ho disattivato tutto");
            }
        }
}


