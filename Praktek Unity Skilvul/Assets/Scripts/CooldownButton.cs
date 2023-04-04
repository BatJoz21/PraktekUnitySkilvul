using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CooldownButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text countdownText;
    [SerializeField] private float duration = 30f;

    float timer;
    bool isCooldown;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        countdownText.text = "";
        button.image.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCooldown == false)
            return;

        timer -= Time.deltaTime;
        countdownText.text = timer.ToString("F1") + " s";
        button.image.fillAmount = 1 - timer / duration;

        if (timer <= 0)
        {
            button.interactable = true;
            countdownText.text = "";
            button.image.fillAmount = 1;
            isCooldown = false;
        }
    }

    public void StartCooldown()
    {
        button.interactable = false;
        timer = duration;
        countdownText.text = timer.ToString("F1") + " s";
        button.image.fillAmount = 1 - timer / duration;
        isCooldown = true;
    }
}
