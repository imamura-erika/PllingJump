using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject clearText;
    private void OnTriggerEnter(Collider other)
    {
        DestroySelf();
        IsCleard(); // �N���A
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void IsCleard()
    {
        // ClearText�\��
        clearText.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        // ������Ԃł�clearText���\��
        if (clearText != null)
        {
            clearText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
