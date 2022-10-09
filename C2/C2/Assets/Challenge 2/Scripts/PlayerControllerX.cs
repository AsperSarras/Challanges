using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool cd = false;
    private float cdCap = 2;
    private float cdCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(cd==true)
        {
            cdCount += Time.deltaTime;
            if(cdCount >= cdCap)
            {
                cdCount = 0;
                cd =false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                cd = true;
            }
        }

        // On spacebar press, send dog

    }
}
