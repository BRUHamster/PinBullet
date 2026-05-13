using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    //UI elements
    [SerializeField] private GameObject _impulseCooldownUI;


    [SerializeField] private GameObject _impulse;
    // Start is called before the first frame update
    
    bool isImpulsReady = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isImpulsReady)
        {
            Instantiate(_impulse, transform.position, Quaternion.identity);
            StartCoroutine(Cooldown(5f, _impulseCooldownUI));
            isImpulsReady = false;
        }
    }



    IEnumerator Cooldown(float cooldownTime, GameObject UIelement)
    {
        UIelement.GetComponent<SpriteRenderer>().DOFade(0.5f, 0.5f);
        yield return new WaitForSeconds(cooldownTime);
        UIelement.GetComponent<SpriteRenderer>().DOFade(1f, 0.5f);
        isImpulsReady = true;
    }
}
