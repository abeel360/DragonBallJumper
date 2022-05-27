using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move_speed = 100f;
    float movimiento;

    public Text perder;
    [SerializeField] private Button restart;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        perder.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);

    }

    void Update()
    {
        //moveX = Input.GetAxis("Horizontal") * move_speed;
        movimiento = Input.acceleration.x * 10f;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movimiento;
        rb.velocity = velocity;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("muerte")){
            Destroy(gameObject);
            perder.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
    }

}
