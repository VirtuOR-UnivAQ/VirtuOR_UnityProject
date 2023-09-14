using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SpawnInfo
{
    public GameObject prefabToSpawn;
    public Transform spawnPosition;
}


public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private SpawnInfo[] spawnInfos; // Questo array conterrà le informazioni su cosa e dove spawnare.

    private void Start()
    {
        // Usiamo la funzione Instantiate per creare un'istanza del prefab nella scena.
        foreach (SpawnInfo spawnInfo in spawnInfos)
        {
            // Assicurati che spawnInfo non sia nullo.
            if (spawnInfo != null && spawnInfo.spawnPosition != null && spawnInfo.prefabToSpawn != null)
            {
                // Istanzia il prefab alla posizione specificata.
                GameObject newObject = Instantiate(spawnInfo.prefabToSpawn, spawnInfo.spawnPosition.position, spawnInfo.spawnPosition.rotation);

                // Puoi fare ulteriori operazioni sull'oggetto appena creato, se necessario.
            }
        }
        // Puoi fare ulteriori operazioni sull'oggetto appena creato, se necessario.
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
