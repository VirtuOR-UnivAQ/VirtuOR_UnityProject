using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Teleport_prova_interactable : MonoBehaviour

{
     [SerializeField]
    public TeleportationProvider teleportationProvider;
    public Transform anchorPoint;  // L'oggetto a cui vuoi teletrasportarti.

    private XRBaseInteractable interactable;
    private bool isTeleporting;

    private void Start()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
       
    }

    public void ActivateTeleport(SelectEnterEventArgs args)
    {
        if (!isTeleporting)
        {
            StartCoroutine(TeleportCoroutine());
        }
    }

    private IEnumerator TeleportCoroutine()
    {
        // Crea una TeleportRequest e imposta la destinazione.
        MatchOrientation m_matchOrientation = MatchOrientation.TargetUp;
        
        TeleportRequest teleportRequest = new TeleportRequest()
        {
            destinationPosition = anchorPoint.position,
            destinationRotation = anchorPoint.rotation,
            matchOrientation = m_matchOrientation
        };

        // Esegui il teletrasporto utilizzando la richiesta.
        teleportationProvider.QueueTeleportRequest(teleportRequest);

        // Attendi il completamento del teletrasporto.
        yield return null;
    }
}






