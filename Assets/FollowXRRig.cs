using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.XR.Interaction.Toolkit;

public class FollowXRRig : MonoBehaviour
{
    public GameObject Reference; // Il controller che seguirà l'XRRig

    private void Update()
    {
        // Verifica se il controller e il transform dell'XRRig sono stati assegnati
        if (Reference != null && Reference != null)
        {
            // Imposta la posizione e la rotazione del controller
            gameObject.transform.position = Reference.transform.position;
            gameObject.transform.rotation = Reference.transform.rotation;

            //gameObject.transform.Translate(0, 3, 2);

        }
    }
}