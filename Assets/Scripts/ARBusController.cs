using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;

public class ARBusController : MonoBehaviour
{
    [SerializeField]
    public GameObject target;

    [SerializeField]
    private Text instuctionText;

    public GameObject GamePage;
    public GameObject ScorePage;
    private double distance;
    private double distanceF;
    System.Random randPerson = new System.Random();
    public GameObject BusController;
    public GameObject obj;
    public GameObject Bus;
    public GameObject Zone1;
    public GameObject Zone2;
    public GameObject Zone3;
    bool spawned = false;
    private ARTaptoPlaceObject placementIndicator;
    public bool inZone = false;
    int busCounter = 0;
    int[] targetArray = new int[11];
    //Menu menu = new Menu();
    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<ARTaptoPlaceObject>();
        GamePage.SetActive(true);
        ScorePage.SetActive(false);
    }
/* 
    private void Update(){
        if(spwnd == true){
            double height = this.gameObject.transform.position.y;
            double altitude = target.transform.position.y - height;
            double length = (target.transform.position - transform.position).magnitude;
            distance = System.Math.Sqrt((length * length) - (altitude* altitude));
            distanceF = distance * 3.28;
        }
        
    } */

    public void advanceScene(){
        Debug.Log("test");
        switch (busCounter){
            default:
                busCounter = 0;
                break;
            case 0:
                placeObject();
                instuctionText.text = "Wait in the green area for the bus";
                busCounter++;
                break;
            case 1:

                    instuctionText.text = "Get on the bus and stand in the new zone";
                    busCounter++;
                    Bus.SetActive(true);
                    Zone1.SetActive(false);
                    Zone2.SetActive(true);
                
                break;
            case 2:

                    instuctionText.text = "Here you will pay for your ride, tap advance to pay for it";
                    busCounter++;
                
                break;
            case 3:

                instuctionText.text = "Now move to the empty seat.";
                Zone2.SetActive(false);
                Zone3.SetActive(true);
                busCounter++;
                
                break;
            case 4:
                instuctionText.text = "When you are near your stop signal the driver";
                busCounter++;
                break;
            case 5:
                instuctionText.text = "When the bus comes to a stop you may leave";
                busCounter++;
                break;
            case 6:
                instuctionText.text = "Tap Advance to end the Activity";
                busCounter++;
                break;
            case 7:
                EndGame();
                break;
        }
        Debug.Log(busCounter);
    }

    public void placeObject(){
        if (spawned != true){
            obj = Instantiate(BusController, placementIndicator.transform.position, placementIndicator.transform.rotation);
            spawned = true;
            Bus = this.obj.transform.Find("Bus").gameObject;
            Zone1 = this.obj.transform.Find("Zone1").gameObject;
            Zone2 = this.obj.transform.Find("Zone2").gameObject;
            Zone3 = this.obj.transform.Find("Zone3").gameObject;
        }
    }
    public void EndGame(){
        GamePage.SetActive(false);
        ScorePage.SetActive(true);
    }
}
