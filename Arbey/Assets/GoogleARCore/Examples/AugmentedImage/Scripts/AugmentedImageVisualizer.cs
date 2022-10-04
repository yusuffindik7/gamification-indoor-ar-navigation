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
        public Text point;
        public GameObject player;
        public GameObject arrow1;
        public GameObject arrow2;
        public GameObject arrow3;
        public GameObject arrow4;
        public GameObject arrow5;
        public GameObject arrow6;
        public GameObject arrow7;
        public GameObject arrow8;
        public GameObject arrow9;
        public GameObject arrow10;
        public GameObject arrow0;

        public AugmentedImage Image;
        public RawImage card;

        public Button startBtn;
        public Button quitBtn;  
        public Button listenBtn;
        public Button trueBtn;  
        public Button falseBtn;
        public Button addBtn;

        private float maxDistance = 1.500f;
        private float tran1 = 0.500f;

        Color myColorTrans = new Color32(22,144,47,130);
        Color myColor = new Color32(22,144,47,255);

        private int clickStart = 0;
        private int clickQuit = 0;
        private int clickListen = 0;
        private int clickTrue = 0;
        private int clickFalse = 0;
        private int clickAdd = 0;

        public void btnStart(){
            clickStart = 1;
            clickQuit = 0;
            clickListen = 0;
            clickTrue = 0;
            clickFalse = 0;
            clickAdd = 0;
        }

        public void btnQuit(){
            clickStart = 0;
            clickQuit = 1;
            clickListen = 0;
            clickTrue = 0;
            clickFalse = 0;
            clickAdd = 0;
        }

        public void btnListen(){
            clickStart = 0;
            clickQuit = 0;
            clickListen = 1;
            clickTrue = 1;
            clickFalse = 1;
            clickAdd = 0;
        }

        public void btnTrue(){
            clickStart = 0;
            clickQuit = 0;
            clickListen = 0;
            clickTrue = 1;
            clickFalse = 0;
            clickAdd = 0;
        }

        public void btnFalse(){
            clickStart = 0;
            clickQuit = 0;
            clickListen = 0;
            clickTrue = 0;
            clickFalse = 1;
            clickAdd = 0;
        }

        public void btnAdd(){
            clickStart = 0;
            clickQuit = 0;
            clickListen = 0;
            clickTrue = 0;
            clickFalse = 0;
            clickAdd = 1;
        }

        public void Update()
        {
            player.transform.position = Camera.current.transform.position;
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                arrow0.SetActive(false);
                arrow1.SetActive(false);
                arrow2.SetActive(false);
                arrow3.SetActive(false);
                arrow4.SetActive(false);
                arrow5.SetActive(false);
                arrow6.SetActive(false);
                arrow7.SetActive(false);
                arrow8.SetActive(false);
                arrow9.SetActive(false);
                arrow10.SetActive(false);
                
                startBtn.gameObject.SetActive(false);
                quitBtn.gameObject.SetActive(false);
                listenBtn.gameObject.SetActive(false);
                trueBtn.gameObject.SetActive(false);
                falseBtn.gameObject.SetActive(false);
                addBtn.gameObject.SetActive(false);

                return;
            }else{
                point.gameObject.SetActive(true);
                startBtn.gameObject.SetActive(true);
                quitBtn.gameObject.SetActive(true);
            }

            if(clickStart == 1){
                point.gameObject.SetActive(true);
                startBtn.gameObject.SetActive(false);
                quitBtn.gameObject.SetActive(true);
                listenBtn.gameObject.SetActive(false);
                trueBtn.gameObject.SetActive(false);
                falseBtn.gameObject.SetActive(false);
                addBtn.gameObject.SetActive(false);
                //OK1
                if(Vector3.Distance(player.transform.position, arrow1.transform.position) < maxDistance){
                    arrow1.SetActive(true);
                    arrow1.transform.position = new Vector3(0f, 0.050f, 0.500f);
                    arrow1.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow1.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow1.transform.position) < tran1){
                    arrow1.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow1.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK2
                if(Vector3.Distance(player.transform.position, arrow2.transform.position) < maxDistance){
                    arrow2.SetActive(true);
                    arrow2.transform.position = new Vector3(0f, 0.050f, 1f);
                    arrow2.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow2.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow2.transform.position) < tran1){
                    arrow2.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow2.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK3
                if(Vector3.Distance(player.transform.position, arrow3.transform.position) < maxDistance){
                    arrow3.SetActive(true);
                    arrow3.transform.position = new Vector3(0f, 0.050f, 1.500f);
                    arrow3.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow3.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow3.transform.position) < tran1){
                    arrow3.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow3.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK4
                if(Vector3.Distance(player.transform.position, arrow4.transform.position) < maxDistance){
                    arrow4.SetActive(true);
                    arrow4.transform.position = new Vector3(0f, 0.050f, 2f);
                    arrow4.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow4.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow4.transform.position) < tran1){
                    arrow4.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow4.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK5
                if(Vector3.Distance(player.transform.position, arrow5.transform.position) < maxDistance){
                    arrow5.SetActive(true);
                    arrow5.transform.position = new Vector3(0f, 0.050f, 2.500f);
                    arrow5.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow5.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow5.transform.position) < tran1){
                    arrow5.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow5.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK6
                if(Vector3.Distance(player.transform.position, arrow6.transform.position) < maxDistance){
                    arrow6.SetActive(true);
                    arrow6.transform.position = new Vector3(0f, 0.050f, 3f);
                    arrow6.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow6.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow6.transform.position) < tran1){
                    arrow6.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow6.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK7
                if(Vector3.Distance(player.transform.position, arrow7.transform.position) < maxDistance){
                    arrow7.SetActive(true);
                    arrow7.transform.position = new Vector3(0f, 0.050f, 3.500f);
                    arrow7.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow7.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow7.transform.position) < tran1){
                    arrow7.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow7.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK8
                if(Vector3.Distance(player.transform.position, arrow8.transform.position) < maxDistance){
                    arrow8.SetActive(true);
                    arrow8.transform.position = new Vector3(0f, 0.050f, 4f);
                    arrow8.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow8.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow8.transform.position) < tran1){
                    arrow8.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow8.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK9
                if(Vector3.Distance(player.transform.position, arrow9.transform.position) < maxDistance){
                    arrow9.SetActive(true);
                    arrow9.transform.position = new Vector3(0f, 0.050f, 4.500f);
                    arrow9.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow9.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow9.transform.position) < tran1){
                    arrow9.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow9.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK10
                if(Vector3.Distance(player.transform.position, arrow10.transform.position) < maxDistance){
                    arrow10.SetActive(true);
                    listenBtn.gameObject.SetActive(true);
                    arrow10.transform.position = new Vector3(0f, 0.050f, 5f);
                    arrow10.transform.rotation = Quaternion.Euler(0f,0f,0f);
                }else{
                    arrow10.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow10.transform.position) < tran1){
                    arrow10.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow10.GetComponent<Renderer>().material.color = myColorTrans;
                }
                //OK0
                if(Vector3.Distance(player.transform.position, arrow0.transform.position) < maxDistance){
                    arrow0.SetActive(true);
                    arrow0.transform.position = new Vector3(0f, 0.050f, 0f);
                    arrow0.transform.rotation = Quaternion.Euler(90f,0f,0f);
                }else{
                    arrow0.SetActive(false);
                }
                if(Vector3.Distance(player.transform.position, arrow0.transform.position) < tran1){
                    arrow0.GetComponent<Renderer>().material.color = myColor;
                }else{
                    arrow0.GetComponent<Renderer>().material.color = myColorTrans;
                }
            
            }
            /*if(clickListen == 1){

            }*/
            /*if(clickTrue == 1){

            }*/
            /*if(clickFalse == 1){

            }*/
        }
    }
}
