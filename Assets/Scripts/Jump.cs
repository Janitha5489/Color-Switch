using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.UI.GridLayoutGroup;

public class Jump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
    bool c;
    public float jumpForce = 8f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public GameObject player;
    public float Force;
    public ParticleSystem Dust;
    bool isPressed = false;
    private void Awake()
    {
        c = true;
    }
    private void OnEnable(){
        Player.OnPouse += Player_OnPouse;
        PausedMenu.OnResume += Player_OnPouse;
    }
    private void OnDisable(){
        Player.OnPouse -= Player_OnPouse;
        PausedMenu.OnResume -= Player_OnPouse;
    }
     private void Player_OnPouse(bool obj){
        if (!obj) {
            c = false;
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
        }
        else {
            c=true;
            rb.gravityScale = 0;
            rb.velocity = Vector2.zero;
        }   
    }
    public void OnPointerDown(PointerEventData eventData){
        if (!c) return;
        //isPressed = true;
        AudioSound.PlaySound("jump");
        Dust.Play();
        rb.gravityScale = 2;
        rb.velocity = Vector2.up * jumpForce;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed=false;
    }
}
