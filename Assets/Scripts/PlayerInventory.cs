using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SG
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;

        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;

        public WeaponItem unarmedWeapon;

        public WeaponItem[] weaponInRightHandSlots = new WeaponItem[2];
        public WeaponItem[] weaponInLeftHandSlots = new WeaponItem[2];

        public int currentRightWeaponIndex = -1;
        public int currentLeftWeaponIndex = -1;

        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }

        private void Start()
        {
            rightWeapon = unarmedWeapon;
            leftWeapon = unarmedWeapon;
        }

        public void ChangeRightWeapon()
        {
            currentRightWeaponIndex++;
            
            if(currentRightWeaponIndex == 0 && weaponInRightHandSlots[0] !=  null)
            {
                rightWeapon = weaponInRightHandSlots[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponInRightHandSlots[currentRightWeaponIndex], false);
            }

            else if(currentLeftWeaponIndex == 0 && weaponInRightHandSlots[0] == null)
            {
                currentRightWeaponIndex++;
            }

            else if(currentRightWeaponIndex == 1 && weaponInLeftHandSlots[1] != null)
            {
                rightWeapon = weaponInRightHandSlots[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponInRightHandSlots[currentRightWeaponIndex], false);
            }

            else
            {
                currentRightWeaponIndex++;
            }

            if (currentRightWeaponIndex > weaponInRightHandSlots.Length - 1)
            {
                currentRightWeaponIndex = 0;
                rightWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }
        }

        public void ChangeLeftWeapon()
        {

        }
    }

}
