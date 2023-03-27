using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int playerHealth;
    [SerializeField] private string playerName;
    [SerializeField] private int playerHP;
    [SerializeField] private int playerDamage;
    [SerializeField] private GameObject playerFriend;
    [SerializeField] private List<string> playerSkills;

    void Awake()
    {
        
    }

    void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Total HP: " + playerHP);
        Debug.Log("Total Damage" + playerDamage);
        Debug.Log(playerFriend);
    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello Update!");
    }

    void LateUpdate()
    {
        
    }

    void OnDisable()
    {
        
    }

    void OnDestroy()
    {
        
    }
}
