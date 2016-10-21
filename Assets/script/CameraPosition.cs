using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

    // Use this for initialization
    public float speed; // Default speed sensitivity
    public Terrain uluru;
    public GameObject midpoint;

    


    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Look at the midpoint
       // transform.LookAt(midpoint.transform);

        transform.Translate(Input.acceleration.x * speed * Time.deltaTime, Input.acceleration.y * speed * Time.deltaTime, 0);


   //     transform.Translate(Input.acceleration.x * speed * Vector3.right * Time.deltaTime);
       

       // transform.Rotate(-Input.acceleration.y * Time.deltaTime * speed, 0, 0);
        
            

       // transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.right);
       // transform.Rotate(-Input.acceleration.y * Time.deltaTime * speed, 0, Input.acceleration.x * Time.deltaTime * speed);
       

        
        
        // Prohibit the user from moving underground or outside the bounds of the terrain
        // The current position of the camera
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        if (posX < 100)
        {
            posX = 100;
        }
        if (posZ < 100)
        {
            posZ = 100;
        }
        if (posX > 900)
        {
            posX = 900;
        }
        if (posZ > 900)
        {
            posZ = 900;
        }
        float height = uluru.terrainData.GetHeight((int)posX, (int)posY);
        //Debug.Log(height);
        if (posY < height + 10)
        {
            posY = height + 10;
        }


        transform.position = new Vector3(posX, posY, posZ);
        transform.localEulerAngles = new Vector3(Mathf.Clamp(transform.localEulerAngles.x, 40, 60), transform.localEulerAngles.y, transform.localEulerAngles.z);
    }

   

}
