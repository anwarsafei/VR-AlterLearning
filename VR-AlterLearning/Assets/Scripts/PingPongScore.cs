using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PingPongScore : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    TMP_Text textScore;

    [Header("VFX")]
    [SerializeField]
    GameObject vfxPrefab;
    [SerializeField]
    Transform spawnedPosition;

    private int currentScore = 0;


    public void AddScore()
    {
        currentScore = currentScore + 1;

        textScore.text = currentScore.ToString();

        SpawnVFX();
    }

    public void SpawnVFX()
    {
        Instantiate(vfxPrefab, spawnedPosition);
    }
}
