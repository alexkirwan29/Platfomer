using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraTransition : MonoBehaviour
{

    public Camera twoD;
    public Camera threeD;
    public bool is3D = false;
    bool oldIs3D = false;

    void Update()
    {

        if (is3D != oldIs3D)
        {
            oldIs3D = is3D;
            Debug.Log("3D mode was changed to " + is3D.ToString());

        }

        if (Input.GetButtonDown("swapCamera"))
        {

            if (is3D = !is3D)
            {
                threeD.gameObject.SetActive(false);

            }
                                                            //at the moment only the 3D camera is changing its state. make it so when you hit "swapCamera" it disables one and enables the other
            else
            {
                threeD.gameObject.SetActive(true);
            }

        }
    }

}
