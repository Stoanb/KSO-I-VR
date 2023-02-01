using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideBalls : MonoBehaviour
{
    public List<MeshRenderer> meshes = new List<MeshRenderer>();

    public bool renderMeshes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (renderMeshes == false)
        {
            for (int i = 0; i < meshes.Count; i++)
            {

                meshes[i].enabled = false;

            }
        }
    }
}
