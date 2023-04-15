using UnityEngine;

public class RedEnemy : MonoBehaviour
{
    LightManager lightManager;
    int hitCount = 0;
    void Start()
    {
        lightManager = GameObject.Find("spritelight").GetComponent<LightManager>();
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.CompareTag("ColorLight")){
            if(lightManager.stateOflight == StateofLight.Green){
                Debug.Log("Yeşil Işık Hasar Veriyor");
                this.transform.Translate(Vector2.left *.5f);
                hitCount++;
                if(hitCount >= 3){
                    Destroy(this.gameObject);
                }
            }
        }   
    }
}
