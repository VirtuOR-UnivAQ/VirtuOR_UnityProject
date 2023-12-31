# VirtuOR Project Repository

## Introduzione

Questa repository contiene i file di progetto Unity di **VirtuOR**. L'intento di questa repository è quello di poter condividere i file necessari alla corretta esecuzione dell'applicazione tramite l'engine Unity.

## Attività iniziali

### Requisiti
La versione corrente di VirtuOR è compatibile con le seguenti versioni dell'Editor di Unity:

* 2021.3.30f1 and later

### Download del progetto (copia locale)

1. Clona o scarica questa repository in uno spazio di lavoro sul tuo disco
     1. Fai clic sul pulsante **⤓ Codice** in questa pagina per ottenere l'URL da clonare con Git o fai clic su **Scarica ZIP** per ottenere una copia di questo repository che puoi estrarre
1. Apri un progetto in Unity
     1. Scarica, installa ed esegui [Unity Hub](https://unity3d.com/get-unity/download)
     1. Nella scheda **Installazioni**, seleziona **Trova** o **Aggiungi** per trovare o installare Unity 2021.3.30f1 o versioni successive.
     1. Nella scheda **Progetti**, fai clic su **Aggiungi**
     1. Passa alla cartella in cui hai scaricato una copia di questo repository e fai clic su **Seleziona cartella**
     1. Verifica che il progetto sia stato aggiunto come **VirtuOR_UnityProject** e fai clic su di esso per aprire il progetto

### Utilizzo del Version Control, Git e GitHub

Dal momento che qualche modifica inaspettata potrebbe compromettere inevitabilmente l’intero progetto, è opportuno salvaguardarsi per poter ripristinare il lavoro ad uno stato precedente.

Per poter sincronizzare le modifiche tra diversi dispositivi si utilizza, appunto GitHub.

La Workstation del laboratorio DEWS è già stata configurata ed è pronta all'utilizzo.

Fare riferimento alla [guida step-by-step](Documentation/Configure_Code_Git.md) per poter settare l'ambiente di sviluppo ideale sul proprio Personal Computer.

## Setup Generale

La scena principale `Bosco_Cartoon` è situata in `Assets/VirtuOR_Elements/Scenes/Ambienti`. Questa sarà la cartella che in futuro conterrà tutte le scene per i diversi ambienti.  
Nella scena `Bosco_Cartoon` sono presenti i seguenti oggetti:
1. [`Complete Set Up`](Documentation/Complete_Set_Up.md) - funge da "corpo" e "testa" dell'utente virtuale e contiene il riferimento ai controller. Questo oggetto segue il movimento e la rotazione dell'utente e serve da punto di ancoraggio per la visualizzazione della scena. Questo è il componente chiave per gestire la posizione e l'orientamento dell'utente nel mondo virtuale.
2. `Environment` - oggetto padre che racchiude:
   - **Terreno**: racchiude gli oggetti con componente `Terrain` e `Teleportation Area`
   - **Animali**: racchiude gli animali con componente `Animator`, in modo da avere le animazioni
   - **Illuminazione**: contiene le luci che illuminano la scena, in questo caso solo la `Directional Light`, che simula la luce naturale solare
   - **Audio**: contiene l'oggetto `Environmental_Sound`, in riproduzione automatica all'attivazione della scena
   - **Objects**: contiene gli oggetti che caratterizzano l'ambiente
3. `MINIGAMES` - oggetto padre che racchiude i due minigiochi presenti nella scena:
   - [Minigame 1: Cannone](Documentation/Minigame_1-Cannon.md)
   - [Minigame 2: Puzzle](Documentation/Minigame_2-Puzzle.md)
4. `Tutorial` oggetto padre che racchiude soltanto l'oggetto `Tutorial_intro`, in modo da avere una guida introduttiva ([Tutorial: Introduction to VR](Documentation/Tutorial_intro.md))



Scripts, assets, animations e prefabs si trovano nella cartella `Assets/VirtuOR_Elements`.

Il sistema di gestione dell'input è l'[Input System](https://docs.unity3d.com/Manual/com.unity.inputsystem.html).  
[Input](Documentation/Input.md).
