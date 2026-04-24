using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarLixo : MonoBehaviour
{
    public LixoSpawnerController lixoSpawnerController;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
            lixoSpawnerController.AddToPoints(1);
        }
    }
}
