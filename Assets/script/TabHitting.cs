using UnityEngine;
using System.Collections;

public class TabHitting : MonoBehaviour {

    private GameObject target;

	// Use this for initialization
	void Start () {
        target = null;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount != 1)
        {
            // only allow one finger touch when using ray casting
            return;
        }

        Touch fingerTouch = Input.touches[0];
        if (fingerTouch.phase == TouchPhase.Began)
        {
            RaycastHit rayhit;
            target = GetTouchObject(out rayhit);
            if (target != null)
            {
                target.SendMessage("Hit");
                PointManager.Instance.IncrementPoint();
            }
        }
    }

    private GameObject GetTouchObject(out RaycastHit hit)
    {
        GameObject touchObj = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("Ray");

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("out");
            if (hit.collider.tag == "Prefab/Moles")
            {
                Debug.Log("hit");
                touchObj = hit.collider.gameObject;
            }
        }

        return touchObj;
    }

}
