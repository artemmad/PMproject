using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PmControler : MonoBehaviour {


    public GameObject korob;
    public GameObject predohran;
    public GameObject mag;
    public GameObject scobe;
    public GameObject spring;
    private int stage = 0;
    



    public void setgo()
    {
        stage++;
        switch(stage){
            case 1:
                {
                    mag.GetComponent<EasyTransform>().isActive = false;
                    predohran.GetComponent<EasyTransform>().isActive = true;
                    break;
                }
            case 2:
                {
                    predohran.GetComponent<EasyTransform>().isActive = false;
                    korob.GetComponent<EasyTransform>().isActive = true;
                    break;
                }

            default:
                stage = 0;
                break;
        }

    }
    // Use this for initialization
    void Start () {
        mag.GetComponent<EasyTransform>().isActive = true;
        predohran.GetComponent<EasyTransform>().isActive = false;
        scobe.GetComponent<EasyTransform>().isActive = false;
        spring.GetComponent<EasyTransform>().isActive = false;
        korob.GetComponent<EasyTransform>().isActive = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
