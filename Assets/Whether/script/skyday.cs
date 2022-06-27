using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RoadGenerator
{
    public class skyday : MonoBehaviour
    {
        public Material skyMats; 
        // Start is called before the first frame update
        void Start()
        {
             GetComponent<Button>().onClick.AddListener(ButtonClick);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void ButtonClick()
        {
            var skyMats = Resources.Load<Material>("Skybox/Materials/day");
            RenderSettings.skybox = skyMats;        
            DynamicGI.UpdateEnvironment();
        }
    }
}
