using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public string npcName;
    public string[] dialogue;

    private bool isInRange = false;

    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E)) // Press E to interact
        {
            StartDialogue();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    void StartDialogue()
    {
        foreach (var line in dialogue)
        {
            Debug.Log(npcName + ": " + line);
        }
    }
}
