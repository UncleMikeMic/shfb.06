using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPositionReset : MonoBehaviour {

	public void ResetPosition60x10x60 ()
    {
        transform.position = new Vector3(0.0f, 37f, -50f);
        transform.eulerAngles = new Vector3(33, 0, 0);
    }
}
