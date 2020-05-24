using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{

    private Light theLight;

    private float targetintensity;
    private float currentlntensity;

    // Start is called before the first frame update
   private void Start()
    {
        theLight = GetComponent<Light>();
        currentlntensity = theLight.intensity;
        targetintensity = Random.Range(0.4f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(targetintensity-currentlntensity) >=0)
        {
            if (targetintensity - currentlntensity >= 0)
                currentlntensity += Time.deltaTime * 3f;
            else
                currentlntensity -= Time.deltaTime * 3f;
             
            theLight.intensity = currentlntensity;
            theLight.range = currentlntensity+10;

        }
        else
        {
            targetintensity = Random.Range(0.4f, 1f);
        }
    }
}
