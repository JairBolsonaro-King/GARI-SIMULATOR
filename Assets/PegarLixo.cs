using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarLixo : MonoBehaviour
{
    public LixoSpawnerController lixoSpawnerController;
    public AudioSource source;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
            source.Play();
            lixoSpawnerController.AddToPoints(1);
        }
    }
}
