using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openPlaneScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void openPlane()
    {
        SceneManager.LoadScene("PlaceOnPlaneScene", LoadSceneMode.Single);
    }
}