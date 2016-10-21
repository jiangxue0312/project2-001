using UnityEngine;
using System.Collections;

public class PointLight : MonoBehaviour {

    public float speed;
    public Color color;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(500, 120, 500), Vector3.left, speed * Time.deltaTime);
        transform.LookAt(new Vector3(500, 120, 500));
    }
    public Vector3 GetWorldPosition()
    {
        return transform.position;
    }
}
