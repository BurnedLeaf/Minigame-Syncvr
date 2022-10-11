using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject WaterPrefab;

    [SerializeField] Vector3 WaterForce;

    [SerializeField] SoundManager soundManager;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction,transform.right).z;
        rb.angularVelocity = -rotateAmount * speed * Time.deltaTime;
    }

    void Shoot()
    {
        soundManager.PlaySound();

        GameObject Water = Instantiate(WaterPrefab, transform.position, transform.rotation);
        Water.GetComponent<Rigidbody2D>().AddRelativeForce(WaterForce);

        Destroy(Water, 4f);
    }
}
