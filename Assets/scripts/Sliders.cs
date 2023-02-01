using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliders : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    public FMODUnity.EventReference fmodEvent;

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
    private float dynamics;

    [SerializeField]
    [Range(0f, 1f)]
    private float room;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
    }

    void Update()
    {
        instance.setParameterByName("vio1_volume", fstVlns);
        instance.setParameterByName("vio2_volume", sndVlns);
        instance.setParameterByName("viola_volume", violas);
        instance.setParameterByName("cellobass_volume", celloBass);
        instance.setParameterByName("brass_volume", brass);
        instance.setParameterByName("woodwind_volume", woodwinds);
        instance.setParameterByName("Dynamic", dynamics);
        instance.setParameterByName("room_volume", room);
    }

    public void AdjustFstVlns(float newFstVlns)
    {
        fstVlns = newFstVlns;
    }

    public void AdjustSndVlns(float newSndVlns)
    {
        sndVlns = newSndVlns;
    }

    public void AdjustViolas(float newViolas)
    {
        violas = newViolas;
    }

    public void AdjustCelloBass(float newCelloBass)
    {
        celloBass = newCelloBass;
    }

    public void AdjustBrass(float newBrass)
    {
        brass = newBrass;
    }

    public void AdjustWoodwinds(float newWoodwinds)
    {
        woodwinds = newWoodwinds;
    }

    public void AdjustDynamics(float newDynamics)
    {
        dynamics = newDynamics;
    }

    public void AdjustRoom(float newRoom)
    {
        room = newRoom;
    }
}
