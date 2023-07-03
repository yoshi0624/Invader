using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyMaker : MonoBehaviour
{
    [SerializeField] private GameObject allyPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float allyZ;
    [SerializeField] private float allyX;
    private float ranX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }
        else
        {
            ranX = Random.Range(allyX * -1, allyX);
            Instantiate(allyPrefab, new Vector3(ranX, 0, allyZ), allyPrefab.transform.rotation);
            waitTime = 0;
        }
    }
}
