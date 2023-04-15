using UnityEngine;
using UnityEngine.Rendering.Universal;


public class LightManager : MonoBehaviour
{
    public StateofLight stateOflight;
    Light2D playerLight;
    private void Start() {
        playerLight = GameObject.Find("spritelight").GetComponent<Light2D>();
    }
    void Update()
    {
        LightMode();
    }
    private void LightMode(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            stateOflight = StateofLight.Red;
            playerLight.color = Color.red;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            stateOflight = StateofLight.Yellow;
            playerLight.color = Color.yellow;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            stateOflight = StateofLight.Green;
            playerLight.color = Color.green;
        }
    }
}
