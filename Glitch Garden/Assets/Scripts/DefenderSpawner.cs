using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    public void OnMouseDown()
    {
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity);
    }
}
