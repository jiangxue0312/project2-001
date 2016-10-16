using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

    // Use this for initialization
    public float speed = 50.0f; // Default speed sensitivity
    public Terrain uluru;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Input.acceleration.x * speed * Time.deltaTime, Input.acceleration.y * speed * Time.deltaTime, 0);
        //   this.transform.Translate(Input.acceleration.z * speed * Vector3.up * Time.deltaTime);


        // Prohibit the user from moving underground or outside the bounds of the terrain
        // The current position of the camera
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        if (posX < 10)
        {
            posX = 10;
        }
        if (posZ < 10)
        {
            posZ = 10;
        }
        if (posX > 990)
        {
            posX = 990;
        }
        if (posZ > 990)
        {
            posZ = 990;
        }
        float height = uluru.terrainData.GetHeight((int)posX, (int)posY);
        //Debug.Log(height);
        if (posY < height + 10)
        {
            posY = height + 10;
        }
        transform.position = new Vector3(posX, posY, posZ);
    }
}
