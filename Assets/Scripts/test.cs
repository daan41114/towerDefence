using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float Speed;
    public GameObject Shotpoint;
    public GameObject Bullet;
    public GameObject lazer;
    public bool Collision;
    private void Update()
    {
        Collision = true;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("i pressed e");
            GameObject newBullet = Instantiate(Bullet, Shotpoint.transform.position, transform.rotation);
            GameObject newLazer = Instantiate(lazer, transform.position, Quaternion.identity);
        }
    }
}
