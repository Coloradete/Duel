using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroAbilities : MonoBehaviour
{
    private PlayerControlls playerControlls;
    private InputAction attackOne, attackTwo;

    private Animator animator;

    private bool isAttacking;
    [SerializeField]private float attackOneCooldown, attackOneTimeActive, attackOneDistance,
        attackTwoCooldown, attackTwoTimeActive, attackTwoDistance;
    [SerializeField]private GameObject attackOneHolder, attackTwoHolder;

    private HeroMovement heroMovement;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        heroMovement = GetComponent<HeroMovement>();

        playerControlls = new PlayerControlls();
        attackOne = playerControlls.HeroController.AttackOne;
        attackTwo = playerControlls.HeroController.AttackTwo;
        attackOne.performed += AttackOnePerformed;
        attackTwo.performed += AttackTwoPerformed;

        attackOneHolder.SetActive(false);
        attackTwoHolder.SetActive(false);
    }


    private void AttackOnePerformed(InputAction.CallbackContext obj)
    {
        StartCoroutine(AttackOne());
    }  
    private void AttackTwoPerformed(InputAction.CallbackContext obj)
    {
        StartCoroutine(AttackTwo());
    }

    private IEnumerator AttackOne()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            animator.SetTrigger("AttackOne");
            Vector3 attackPosition = heroMovement.GetMovementDirection();
            attackOneHolder.transform.localPosition = attackPosition * attackOneDistance;
            attackOneHolder.SetActive(true);
            AudioManager.instance.HeroSlashAttack();
            yield return new WaitForSeconds(attackOneTimeActive);
            attackOneHolder.SetActive(false);
            yield return new WaitForSeconds(attackOneCooldown);
            isAttacking = false;
        }

    } 
    private IEnumerator AttackTwo()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            animator.SetTrigger("AttackTwo");
            Vector3 attackPosition = heroMovement.GetMovementDirection();
            attackTwoHolder.transform.localPosition = attackPosition * attackTwoDistance;
            attackTwoHolder.SetActive(true);
            AudioManager.instance.HeroSlashAttack();
            yield return new WaitForSeconds(attackTwoTimeActive);
            attackTwoHolder.SetActive(false);
            yield return new WaitForSeconds(attackTwoCooldown);
            isAttacking = false;
        }
    }
    private void OnEnable()
    {
        playerControlls.Enable();
        attackOne.Enable();
        attackTwo.Enable();
    }
    private void OnDisable()
    {
        playerControlls.Disable();
        attackOne.Disable();
        attackTwo.Disable();
    }
}
