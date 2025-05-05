using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FinishTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger hit by: {other.name} (tag: {other.tag})");

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected—calling OnPlayerFinished()");
            FindObjectOfType<GameController>().OnPlayerFinished();
        }
    }
}
