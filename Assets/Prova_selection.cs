using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Prova_selection : MonoBehaviour
{
    [SerializeField]
    public XRInteractionManager interactionManager;
    [SerializeField]
    public XRBaseInteractable interactableToSelect;
    [SerializeField]
    public XRBaseControllerInteractor interactorToUse;


    private void Start()
    {

    }
    public void EnableSelection()
    {

        var selectInteractor = interactorToUse as IXRSelectInteractor;
        var selectInteractable = interactableToSelect as IXRSelectInteractable;

        interactionManager.SelectEnter(selectInteractor, selectInteractable);
    }

    /* public void DisableSelection()
    {
        interactionManager.SelectExit(interactorToUse,interactableToSelect);
    } */
}