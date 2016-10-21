using UnityEngine;
using System.Collections;

public class MidpointRotate : MonoBehaviour {
    public float spinSpeed;
    private bool right_rotate = false;
    private bool left_rotate = false;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
        // rotate around the midpoint
        // click the button
        if (left_rotate)
        {
            transform.localRotation *= Quaternion.AngleAxis(Time.deltaTime * spinSpeed, Vector3.up);
            
            //transform.RotateAround(midpoint.transform.position, Vector3.up, 20 * Time.deltaTime);
        }
        if (right_rotate)
        {
            transform.localRotation *= Quaternion.AngleAxis(Time.deltaTime * spinSpeed, Vector3.down);
            
            //transform.RotateAround(midpoint.transform.position, Vector3.down, 20 * Time.deltaTime);
        }

        //this.transform.localRotation *= Quaternion.AngleAxis(Time.deltaTime * spinSpeed, Vector3.right);

    }


    public void OnPress_right()
    {
        right_rotate = true;
    }

    public void OnRelease_right()
    {
        right_rotate = false;
    }

    public void OnPress_left()
    {
        left_rotate = true;
    }

    public void OnRelease_left()
    {
        left_rotate = false;
    }
}
