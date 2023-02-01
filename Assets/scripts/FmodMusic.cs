using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;

public class FmodMusic : MonoBehaviour
{
    public GameObject dynamic_Slider_Controller; 

    [Header("Dynamic Controller")]
    public GameObject L_controller;
    public GameObject R_controller;
    //public float L_controllerPosY;
    //public float R_controllerPosY;
    //public float StartControllingDynamicPos; 
    //public float controllerStartPos;
    //public float controllerDeadzone;
    //public float controllerAddEndZone;
    //public float maxYRange; 
    //public float howMuchRangeFor_0_to_1;
    public float dynamicsValue;
    public bool startTheGame; 
    //public bool gatherPosData;
    public bool adjustingDynamics;
    public bool allInstrumentsPalaying; 
    public float controllerDynamicSValue;

    //public Animator rampAnimator;

    public XRRayInteractor rRayInteractor; 

    public bool masterBankLoaded;
    [Header("Volume sliders")]
    public List<Slider> sliderList = new List<Slider>();
    public Slider slider_fstVlns;
    public Slider slider_sndVlns;
    public Slider slider_violas;
    public Slider slider_cellobass;
    public Slider slider_brass;
    public Slider slider_woodwinds;
    public Slider slider_dynamics;
    public Slider slider_Room;

    public int instruments_SoloController; 
    
    public FMODUnity.StudioEventEmitter test; 

    private FMOD.Studio.EventInstance instance;

    public FMODUnity.EventReference fmodEvent;
    public TMP_Text debugText; 

    [SerializeField]
    [Range(0f, 1f)]
    private float fstVlns;

    [SerializeField]
    [Range(0f, 1f)]
    private float sndVlns;

    [SerializeField]
    [Range(0f, 1f)]
    private float violas;

    [SerializeField]
    [Range(0f, 1f)]
    private float celloBass;

    [SerializeField]
    [Range(0f, 1f)]
    private float brass;

    [SerializeField]
    [Range(0f, 1f)]
    private float woodwinds;

    [SerializeField]
    [Range(0f, 1f)]
    public float dynamics;

    [SerializeField]
    [Range(0f, 1f)]
    private float room;


    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);

        masterBankLoaded = false;

        allInstrumentsPalaying = true;

        startTheGame = false;

        slider_Room.value = 0.15f; 


    }

    void Update()
    {
        RaycastResult res;
      
        if (rRayInteractor.TryGetCurrentUIRaycastResult(out res))
        {
            if (res.gameObject.name == "Handle")
            {
                if (res.gameObject.GetComponentInParent<Slider>().value >= 0.99f)
                {
                    instruments_SoloController = int.Parse(res.gameObject.tag.ToString());

                    Debug.Log(instruments_SoloController);

                    NewSoloInstrument();

                }
                else
                {
                    
                    
                }
            }

        }

        CheckForSoloInstruments();

       

       fstVlns = slider_fstVlns.value;
       sndVlns = slider_sndVlns.value;
       violas = slider_violas.value;
       celloBass = slider_cellobass.value;
       brass = slider_brass.value;
       woodwinds = slider_woodwinds.value;
       dynamics = slider_dynamics.value;
       room = slider_Room.value;
    
        instance.setParameterByName("vio1_volume", fstVlns);
        instance.setParameterByName("vio2_volume", sndVlns);
        instance.setParameterByName("viola_volume", violas);
        instance.setParameterByName("cellobass_volume", celloBass);
        instance.setParameterByName("brass_volume", brass);
        instance.setParameterByName("woodwind_volume", woodwinds);
        instance.setParameterByName("Dynamic", dynamics);
        instance.setParameterByName("room_volume", room);

        instance.setParameterByName("Solo", instruments_SoloController);


        if (FMODUnity.RuntimeManager.HaveAllBanksLoaded && masterBankLoaded == false)
        {
            Debug.Log("Master bank has been loaded");
            masterBankLoaded = true; 

        }
    }

    public void adjustSliderwithController(float StartControllingDynamicPos, float maxYRange, float L_controllerPosY)
    {
      
            controllerDynamicSValue = Mathf.InverseLerp(StartControllingDynamicPos, maxYRange, L_controllerPosY);
            instance.setParameterByName("Dynamic", controllerDynamicSValue);
            slider_dynamics.value = controllerDynamicSValue;
           // Debug.Log(controllerDynamicSValue);

     
    }

    public void SetDefaultDynamic()
    {
        slider_dynamics.value = 0.5f;
       
    }

    

    public void startMusic()
    {
        instance.start();
    }

    public void pauseMusic()
    {
        instance.setPaused(true);
    }
    public void playMusic()
    {
        instance.setPaused(false);
     
    }

    public void ResetAllSliders()
    {
        slider_fstVlns.value = 0.5f;
        slider_sndVlns.value = 0.5f;
        slider_violas.value = 0.5f;
        slider_cellobass.value = 0.5f;
        slider_brass.value = 0.5f;
        slider_woodwinds.value = 0.5f;
        instruments_SoloController = 0; 
       
    }

   
    public void NewSoloInstrument()
    {
        for (int i = 0; i < sliderList.Count; i++)
        {
            if (sliderList[i].value > 0.95f && sliderList[i] != sliderList[instruments_SoloController])
            {
                sliderList[i].value = 0.85f; 
            }
        }
    }

    public void CheckForSoloInstruments()
    {
        for (int i = 0; i < sliderList.Count; i++)
        {
            if (sliderList[i].value >= 0.99f)
            {
                allInstrumentsPalaying = false;
                break;
            }
            else if (sliderList[i].value < 0.99f)
            {
                allInstrumentsPalaying = true; 
            }

        }

        if (allInstrumentsPalaying)
        {
            instruments_SoloController = 0;
        }
    }
    

 
}
