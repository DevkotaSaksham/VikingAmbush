using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering.PostProcessing;
public class postprocessing : MonoBehaviour
{
    public static postprocessing instance;
    public GameObject volume;
    UnityEngine.Rendering.VolumeProfile profile;
    UnityEngine.Rendering.Universal.ChromaticAberration myChromaticAberration;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        profile = volume.GetComponent<UnityEngine.Rendering.Volume>().profile;
        profile.TryGet(out myChromaticAberration);
        myChromaticAberration.intensity.Override(0);
    }


    public IEnumerator screenaberate()
    {
        //float counter = 0;
        //float duration = 1.2f;
        float value = 1f;
        if (myChromaticAberration == null) { Debug.Log("null"); }
        myChromaticAberration.intensity.Override(value);

        while (value > 0)
        {
            value -= Time.deltaTime;
            myChromaticAberration.intensity.Override(value);
            yield return null;

        }

    }
}
