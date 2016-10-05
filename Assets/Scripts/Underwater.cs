using UnityEngine;
using System.Collections;

//This script enables the underwater effect. Attach it to the main camera
public class Underwater : MonoBehaviour {

    public Color fogColor; //Color of the fog
    public Transform water; //The water transform
    public float maxFogDensity = 0.1f; //The maximum density of the underwater fog

    //save the fog settings
    private bool savedFogEnabledFlag;
    private Color savedFogColor;
    private float savedFogDensity;
    private Material savedSkyboxMaterial;

    private bool isUnderWater = false;
    private float underwaterLevel;


    // Use this for initialization
    void Start () {
        Camera.main.backgroundColor = fogColor;

        //save the scene default fog settings 
        savedFogEnabledFlag = RenderSettings.fog;
        savedFogColor = RenderSettings.fogColor;
        savedFogDensity = RenderSettings.fogDensity;
        savedSkyboxMaterial = RenderSettings.skybox;
        
        //cache the water surface level
        underwaterLevel = water.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        //if main camera is under water
        if (transform.position.y > underwaterLevel)
        {
            if (false == isUnderWater)
            {
                //Enable fog
                RenderSettings.fog = true;

                //Set fog color
                RenderSettings.fogColor = fogColor;

                //Set fog density
                RenderSettings.fogDensity = maxFogDensity;

                //Turn off skybox
                RenderSettings.skybox = null;

                //Remember we are under water
                isUnderWater = true;
            }
        }
        else
        {
            if (true == isUnderWater)
            {
                RenderSettings.fog = savedFogEnabledFlag;
                RenderSettings.fogColor = savedFogColor;
                RenderSettings.fogDensity = savedFogDensity;
                RenderSettings.skybox = null;

                isUnderWater = false;
            }
        }
	
	}
}
