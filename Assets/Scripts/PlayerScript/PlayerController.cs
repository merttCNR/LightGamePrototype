using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float xMove;
    Vector2 playerDir;
    Light2D light2d;
    CircleCollider2D lightCollider;
    public FuelManager fuelManager;
    private bool isFueled;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        lightCollider = GameObject.Find("spritelight").GetComponent<CircleCollider2D>();
        light2d = GameObject.Find("spritelight").GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }
    void FixedUpdate(){
        PlayerInput();
        PlayerMove();
        FuelCheck();
        LightRadius();
        RadiusCheck();
        
    }
    private void PlayerMove(){
        rb.velocity = playerDir * 10;
    }
    private void PlayerInput(){
         xMove = Input.GetAxis("Horizontal");
         playerDir = new Vector2(xMove,0);

    }
    private void LightRadius(){
        if(Input.GetKey(KeyCode.Space) && light2d.pointLightOuterRadius < 5f && isFueled){
            fuelManager.currentFuel -= Time.deltaTime;//!!!
            light2d.pointLightOuterRadius += Time.deltaTime;
            lightCollider.radius += Time.deltaTime; 
            if(fuelManager.currentFuel <= 0){
                fuelManager.currentFuel = 0;
                isFueled = false;
            }
        }
        else if (light2d.pointLightOuterRadius >= 0){
            light2d.pointLightOuterRadius -= Time.deltaTime*.5f;
            lightCollider.radius -= Time.deltaTime*.5f;
        }
    }
    private void FuelCheck(){
        if(fuelManager.isTriggered){
            fuelManager.currentFuel = fuelManager.maxFuel;
            isFueled = true;
        }
        fuelManager.isTriggered = false;//çalışıyor.
    }
    private void RadiusCheck(){
            if(lightCollider.radius < 0.5f){
                Debug.Log("radius zort");
                lightCollider.enabled = false;
            }
            else{
                Debug.Log("radius UP");
                lightCollider.enabled = true;
            }
    }
}
