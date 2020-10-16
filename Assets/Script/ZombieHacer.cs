using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHacer : MonoBehaviour
{
    public GameObject Zombie;
    private Transform _transform;
    private float tiempo = 0f;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {

        tiempo += Time.deltaTime;
        Debug.Log(tiempo);
        if (tiempo >= 4)
        {
            Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate(Zombie, _transform.position, Quaternion.identity);
            tiempo = 0;
        }
    }
}
