using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float regularSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float rotateSpeed = 200f;
    [SerializeField] TMP_Text boostText ;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedUP") && (currentSpeed != boostSpeed))
        {
            currentSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject, 0.5f);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        currentSpeed = regularSpeed;
        boostText.gameObject.SetActive(false);
    }
    void Update()
    {   
        float rotate = 0f;  
        float move = 0f;
        
        if(Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            move = -.5f;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            rotate = 1f;
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            rotate = - 1f;
        }
        float rotateAmount = rotate * rotateSpeed * Time.deltaTime;
        float moveAmount = move * currentSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotateAmount);
        transform.Translate(0, moveAmount , 0);
    }
}
