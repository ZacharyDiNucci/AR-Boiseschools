using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;

public class ARRestController : MonoBehaviour
{
    [SerializeField]
    private Text instuctionText;

    public GameObject GamePage;
    public GameObject ScorePage;
    private double distance;
    private double distanceF;
    System.Random randPerson = new System.Random();
    public GameObject RestController;
    public GameObject obj;
    public GameObject Table;
    public GameObject Zone1;
    public GameObject WaiterF;
    public GameObject Food;
    public GameObject NapkinU;
    public GameObject NapkinW;
    bool spawned = false;
    private ARTaptoPlaceObject placementIndicator;
    int restCounter = 0;
    int[] targetArray = new int[11];
    void Start()
    {
        placementIndicator = FindObjectOfType<ARTaptoPlaceObject>();
        GamePage.SetActive(true);
        ScorePage.SetActive(false);
    }
    public void advanceScene(){
        Debug.Log("test");
        switch (restCounter){
            default:
                restCounter = 0;
                break;
            case 0:
                placeObject();
                instuctionText.text = "Please Sit in the Green Area";
                restCounter++;
                break;
            case 1:
                instuctionText.text = "Welcome To the Restauraunt";
                restCounter++;
                Table.SetActive(true);
                NapkinW.SetActive(true);
                Zone1.SetActive(false);
                break;
            case 2:
                instuctionText.text = "Here is Your Waiter, Tap what you would like on the menu";
                restCounter++;
                WaiterF.SetActive(true);
                break;
            case 3:
                instuctionText.text = "He will now leave and tell the cooks to make your order";
                restCounter++;
                WaiterF.SetActive(false);
                break;
            case 4:
                instuctionText.text = "Lets unroll your napkin so you are ready to eat";
                restCounter++;
                break;
            case 5:
                instuctionText.text = "Just a little bit longer and the waiter should be back";
                restCounter++;
                NapkinW.SetActive(false);
                NapkinU.SetActive(true);
                break;
            case 6:
                instuctionText.text = "The waiter is back with your Food";
                restCounter++;
                WaiterF.SetActive(true);
                Food.SetActive(true);
                break;
            case 7:
                instuctionText.text = "Thank Your Waiter and enjoy the food";
                restCounter++;
                WaiterF.SetActive(false);
                break;
            case 8:
                instuctionText.text = "Tap Advance To End";
                restCounter++;
                break;
            case 9:
                EndGame();
                break;
        }
        Debug.Log(restCounter);
    }
    public void placeObject(){
        if (spawned != true){
            obj = Instantiate(RestController, placementIndicator.transform.position, placementIndicator.transform.rotation);
            spawned = true;
            Table = this.obj.transform.Find("Table").gameObject;
            Zone1 = this.obj.transform.Find("Zone1").gameObject;
            WaiterF = this.obj.transform.Find("SimpleChildF").gameObject;
            Food = this.obj.transform.Find("Food").gameObject;
            NapkinW = this.obj.transform.Find("NapkinW").gameObject;
            NapkinU = this.obj.transform.Find("NapkinU").gameObject;
        }
    }
    public void EndGame(){
        GamePage.SetActive(false);
        ScorePage.SetActive(true);
    }
}
