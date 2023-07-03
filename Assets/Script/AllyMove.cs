using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllyMove : MonoBehaviour
{
    [SerializeField] private float allySpeed;
    [SerializeField] private float allyLifeTime;

    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, allySpeed) * Time.deltaTime);

        allyLifeTime = allyLifeTime - Time.deltaTime;
        if (allyLifeTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            Debug.Log("Bullet");
            SceneManager.LoadScene("End");
        }
    }
}
