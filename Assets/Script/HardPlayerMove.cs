﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardPlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float zMax;
    [SerializeField] private float zMin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)
        {

            transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);//�ړ��̂��߂̃v���O����
        }
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin)
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);//�ړ��̂��߂̃v���O����
        }
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
        {
            transform.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);//�ړ��̂��߂̃v���O����
        }
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin)
        {
            transform.Translate(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);//�ړ��̂��߂̃v���O����
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("HardEnd");
    }

}
