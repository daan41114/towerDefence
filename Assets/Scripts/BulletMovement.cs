using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject bullet;
    public GameObject lazer;
    public GameObject Indicator;
    public float speed;
    public float Lifetime;
    void Update()
    {
        if (bullet == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            GameObject newLazer = Instantiate(lazer, transform.position, Quaternion.identity);

        }
    }
}
