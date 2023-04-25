using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject dead;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        dead.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deadScene()
    {
        dead.SetActive(true);
        isDead = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
