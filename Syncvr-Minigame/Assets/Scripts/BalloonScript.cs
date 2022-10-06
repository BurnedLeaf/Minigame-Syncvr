using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    [SerializeField] Vector3 force;

    [SerializeField] Sprite[] balloonSprites;

    private Rigidbody2D rb;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();

        SpriteRenderer.sprite = balloonSprites[Random.Range(0, 5)];

        force = new Vector3(Random.Range(-35, 35), Random.Range(150, 200), 0);

        transform.position = new Vector3(Random.Range(-4.60f, 4.60f),transform.position.y,transform.position.z);

        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        } else if (collision.gameObject.tag == "water")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
     
    }

    
}
