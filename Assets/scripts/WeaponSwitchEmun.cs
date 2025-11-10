
using UnityEngine;

public enum WeaponType { Sword, Bow, Staff, Dagger }

public class WeaponSwitchEmun : MonoBehaviour
{
    public WeaponType selectedWeapon = WeaponType.Sword;

    void Start()
    {
        // no automatic SelectWeapon call here (per request)
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            selectedWeapon = WeaponType.Sword;
            SelectWeapon(selectedWeapon);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            selectedWeapon = WeaponType.Bow;
            SelectWeapon(selectedWeapon);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            selectedWeapon = WeaponType.Staff;
            SelectWeapon(selectedWeapon);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            selectedWeapon = WeaponType.Dagger;
            SelectWeapon(selectedWeapon);
        }
    }

    void SelectWeapon(WeaponType wt)
    {
        switch (wt)
        {
            case WeaponType.Sword:
                Debug.Log("Sword selected - strong close range. damage 25, speed 1.0");
                break;
            case WeaponType.Bow:
                Debug.Log("Bow selected - long range and fast. damage 20, speed 1.5");
                break;
            case WeaponType.Staff:
                Debug.Log("Staff selected - powerful but uses mana. damage 35, speed 0.7");
                break;
            case WeaponType.Dagger:
                Debug.Log("Dagger selected - fast and agile. damage 15, speed 2.0");
                break;
            default:
                Debug.Log("No weapon selected");
                break;
        }
    }
}
