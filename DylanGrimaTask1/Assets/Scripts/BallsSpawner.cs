using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsSpawner : MonoBehaviour
{

    public GameObject circle;
    public float padding;

    private float XMin, XMax, YMin, YMax; 

    // Start is called before the first frame update
    void Start()
    {
        Camera myCamera = Camera.Main;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;

        Instantiate(circle, new Vector3(XMin, YMin, 0), Quaternion.identity);
        Instantiate(circle, new Vector3(XMin, YMax, 0), Quaternion.identity);
        Instantiate(circle, new Vector3(XMax, YMin, 0), Quaternion.identity);
        Instantiate(circle, new Vector3(XMax, YMax, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
