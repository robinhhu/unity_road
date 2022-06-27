using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RoadGenerator
{
    public class rain : MonoBehaviour
    {
        private ParticleSystem ps;
        // Start is called before the first frame update
        void Start()
        {
             //GetComponent<Button>().onClick.AddListener(ButtonClick);
             ps = GetComponent<ParticleSystem>();
             var em = ps.emission;
             em.enabled = true;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void ButtonClick()
        {
            //Debug.Log("Listener 的方法！");
            //var em = ps.emission;
            //em.enabled = true;
        }
    }
}
