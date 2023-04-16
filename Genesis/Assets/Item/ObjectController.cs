
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject controlable;
    private void OnTriggerEnter2D(Collider2D player) 
    {
        if (player.CompareTag("Player"))
        {
            Debug.Log("Player collision");
            if (controlable.activeSelf)
            {
                controlable.SetActive(false);
            }
            else
            {
                controlable.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
