using UnityEngine;

public class WeaponSwitchEmun : MonoBehaviour
{
    string currentWeapon = "default";   
   
    void Start()
    {
         
    } 

   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
            currentWeapon = "sword";
            Debug.Log (" You selected the sword: strong and close range.");
        if (Input.GetKeyDown(KeyCode.W))
            currentWeapon = "bow";
            Debug.Log (" You selected the bow: long range and fast.");
        if (Input.GetKeyDown(KeyCode.E))
            currentWeapon = "staff";
            Debug.Log (" You selected the magic staff: powerful but uses mana.");
        if (Input.GetKeyDown(KeyCode.R))
            currentWeapon = "dagger";
            Debug.Log (" You selected the hammer: heavy, slow, but deals massive damage.");
        if (Input.GetKeyDown(KeyCode.T))
            currentWeapon = "default";
            Debug.Log (" You selected the default: basic weapon with balanced stats.");

        


        switch (currentWeapon)
        {
            case "sword":
                Debug.Log("sword selected");
                Debug.Log("damage 25, speed 1.0");
                break;
            case "bow":
                Debug.Log("bow selected");
                Debug.Log("damage 20, speed 1.5");
                break;
            case "staff":
                Debug.Log("staff selected");
                Debug.Log("damage 35, speed 0.7");
                break;
            case "dagger":
                Debug.Log("dagger selected");
                Debug.Log("damage 15, speed 2.0");
                break;
            case "default":
                Debug.Log("default selected");
                Debug.Log("damage 10, speed 1.0");
                break;
            default:
                Debug.Log("No weapon selected");
                break;
        }
    }
}
