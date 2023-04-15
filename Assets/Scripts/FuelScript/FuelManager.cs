using UnityEngine;

public class FuelManager : MonoBehaviour
{
    public float currentFuel = 0;
    public float maxFuel = 5f;
    public bool isTriggered;
   private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            isTriggered = true;
        }
    }
}
