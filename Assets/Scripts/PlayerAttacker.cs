using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SG
{
    public class PlayerAttacker : MonoBehaviour
    {
        public AnimatorHandler animatorHandler;
        private InputHandler inputHandler;
        public string lastAttack;

        private void Awake()
        {   
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            inputHandler = GetComponent<InputHandler>();
        }

        public void HandleWeaponCombo(WeaponItem weapon)
        {
            if (inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canDoCombo", false);
                
                if (lastAttack == weapon.OH_Light_Attack_1)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_2, true);
                    animatorHandler.anim.SetBool("canDoCombo", false);
                    lastAttack = weapon.OH_Light_Attack_2;
                }
                else if (lastAttack == weapon.OH_Light_Attack_2)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_3, true);
                    animatorHandler.anim.SetBool("canDoCombo", false);
                }
            }
            
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            if (weapon == null)
            {
                Debug.Log("No weapons");
                return;
            }
            animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
            lastAttack = weapon.OH_Light_Attack_1;
        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            if (weapon == null)
            {
                Debug.Log("No weapons");
                return;
            }
            animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
            lastAttack = weapon.OH_Light_Attack_1;
        }
    }
}

