using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PasarScnene : MonoBehaviour
{

    public string nextlever;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PasarEcena()
    {
      SceneManager.LoadScene(nextlever);
    }
}
