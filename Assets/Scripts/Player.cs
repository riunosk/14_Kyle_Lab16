using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawn;

    private float movespeed = 5f;
    private float rotatespeed = 200f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
            transform.position += transform.forward * movespeed * Time.deltaTime;
		}
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -Time.deltaTime * rotatespeed, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, Time.deltaTime * rotatespeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
		{
            Instantiate(bulletPrefab, bulletSpawn.transform.position, transform.rotation);
		}
    }
}
