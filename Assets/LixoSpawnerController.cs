using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximumX;
    public float fixedY;
    public float fixedZ;
    public float timer;
    public GameObject Lixo;
    public int MaxPoints;
    public int points = 0;

    public TMP_Text pointsText;
    public TMP_Text victoryText;
    private int counter = 0;

    IEnumerator SpawnRoutine()
    {
        while (points < MaxPoints)
        {
            Instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX + 1), fixedY, fixedZ), Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }
        victoryText.gameObject.SetActive(true);
    }

    public void AddToPoints(int x)
    {
        points += x;

        // Impede que fique negativo
        if (points < 0)
        {
            points = 0;
        }

        pointsText.text = "Pontuação: " + points.ToString();
    }

    void Start()
    {
        GameObject Menu = GameObject.FindWithTag("Menu");

        StartCoroutine(SpawnRoutine());
        pointsText.text = "Pontuação: 0";
        victoryText.gameObject.SetActive(false);
    }

    private void comecar()
    {
        GameObject Menu = GameObject.FindWithTag("Menu");
        if (counter < 1)
        {
            if (Menu.activeInHierarchy == false)
            {

            }
        }
    }

    void Update()
    {

    }
}