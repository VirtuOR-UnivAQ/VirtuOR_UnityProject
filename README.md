# VirtuOR Project Repository

## Introduzione

Questa repository contiene i file di progetto Unity di **VirtuOR**. L'intento di questa repository è quello di poter condividere i file necessari alla corretta esecuzione dell'applicazione tramite l'engine Unity.

## Attività iniziali

### Requisiti
La versione corrente di VirtuOR è compatibile con le seguenti versioni dell'Editor di Unity:

* 2021.3.30f1 and later

### Download del progetto

1. Clona o scarica questa repository in uno spazio di lavoro sul tuo disco
     1. Fai clic sul pulsante **⤓ Codice** in questa pagina per ottenere l'URL da clonare con Git o fai clic su **Scarica ZIP** per ottenere una copia di questo repository che puoi estrarre
1. Apri un progetto in Unity
     1. Scarica, installa ed esegui [Unity Hub](https://unity3d.com/get-unity/download)
     1. Nella scheda **Installazioni**, seleziona **Trova** o **Aggiungi** per trovare o installare Unity 2021.3.30f1 o versioni successive.
     1. Nella scheda **Progetti**, fai clic su **Aggiungi**
     1. Passa alla cartella in cui hai scaricato una copia di questo repository e fai clic su **Seleziona cartella**
     1. Verifica che il progetto sia stato aggiunto come **VirtuOR_UnityProject** e fai clic su di esso per aprire il progetto

## Setup Generale

La scena principale `Bosco_Cartoon` è situata in `Assets/VirtuOR_Elements/Scenes/Ambienti`. Questa sarà la cartella che in futuro conterrà tutte le scene per i diversi ambienti.  
Nella scena `Bosco_Cartoon` sono presenti i seguenti oggetti:
1. `Complete Set Up` funge da "corpo" e "testa" dell'utente virtuale e contiene il riferimento ai controller. Questo oggetto segue il movimento e la rotazione dell'utente e serve da punto di ancoraggio per la visualizzazione della scena. Questo è ilcomponente chiave per gestire la posizione e l'orientamento dell'utente nel mondo virtuale.
2. `Environment` oggetto padre che racchiude:
   - **Terreno**: racchiude gli oggetti con componente `Terrain` e `Teleportation Area`
   - **Animali**: racchiude gli animali con componente `Animator`, in modo da avere le animazioni
   - **Illuminazione**: contiene le luci che illuminano la scena, in questo caso solo la `Directional Light`, che simula la luce naturale solare
   - **Audio**: contiene l'oggetto `Environmental_Sound`, in riproduzione automatica all'attivazione della scena
   - **Objects**: contiene gli oggetti che caratterizzano l'ambiente
3. `MINIGAMES` oggetto padre che racchiude i due minigiochi presenti nella scena:
   - [Minigame 1: Cannone](Documentation/Minigame_1-Cannon.md)
   - [Minigame 2: Puzzle](Documentation/Minigame_2-Puzzle.md)
5. `Tutorial` oggetto padre che racchiude soltanto l'oggetto `Tutorial_intro`, in modo da avere una guida introduttiva ([Tutorial: Introduction to VR](Documentation/Tutorial_intro.md))

[**XR Origin**](https://docs.unity3d.com/2021.3/Documentation/Manual/xr-origin.html) si trova all'interno del prefab **Complete Set Up**. Questo prefab contiene tutto il necessario per un'interazione dell'utente completamente funzionale con [**XRI**](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.4/manual/index.html). Ciò include i componenti necessari per l'input generale, l'interazione con gli oggetti e l'interazione con interfaccia utente.

Scripts, assets, animations e prefabs si trovano nella cartella `Assets/VirtuOR_Elements`.

Il sistema di gestione dell'input è l'[Input System](https://docs.unity3d.com/Manual/com.unity.inputsystem.html).  
[Input](Documentation/Input.md).
