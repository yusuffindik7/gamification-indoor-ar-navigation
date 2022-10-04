namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class AugmentedImageVisualizer : MonoBehaviour
    {
        public GameObject player;
        public GameObject Object1;
        public GameObject Object2;
        public GameObject Object3;
        public GameObject Object4;
        public GameObject Object5;
        public GameObject Object6;
        public GameObject Object7;
        
        public AugmentedImage Image;

        private float maxDistance = 1.500f;
        private float tran1 = 0.500f;

        public void Update()
        {
            player.transform.position = Camera.current.transform.position;
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                Object1.gameObject.SetActive(false);
                Object2.gameObject.SetActive(false);
                Object3.gameObject.SetActive(false);
                Object4.gameObject.SetActive(false);
                Object5.gameObject.SetActive(false);
                Object6.gameObject.SetActive(false);
                Object7.gameObject.SetActive(false);

                return;
            }else{
                
                Object1.SetActive(true);
                Object1.transform.position = new Vector3(1f, -1.200f, 1f);
                Object1.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

                Object2.SetActive(true);
                Object2.transform.position = new Vector3(3f, -1.000f, 2f);
                Object2.transform.rotation = Quaternion.Euler(-90f, 0f, 90f);

                Object3.SetActive(true);
                Object3.transform.position = new Vector3(3.500f, -1.200f, 3f);
                Object3.transform.rotation = Quaternion.Euler(-90f, 0f, 90f);
                
                Object4.SetActive(true);
                Object4.transform.position = new Vector3(-1f, -1.200f, -1f);
                Object4.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

                Object5.SetActive(true);
                Object5.transform.position = new Vector3(-2f, -1.200f, -2f);
                Object5.transform.rotation = Quaternion.Euler(-90f, 0f, 90f);

                Object6.SetActive(true);
                Object6.transform.position = new Vector3(-2.500f, -1f, -3f);
                Object6.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);

                Object7.SetActive(true);
                Object7.transform.position = new Vector3(-3f, -1f, -3f);
                Object7.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);

            }
        }
    }
}