using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        //
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);
        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

        // Classes and Struct Stuff 
        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Sir Cranky Pants";
        Character heroine = new Character("Maude");
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        heroine.PrintStatsInfo();
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        Weapon mageStaff = new Weapon("Staff of Light", 5000);
        warBow.name = "War Bow";
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
        Paladin knight = new Paladin("Sar Arthur", huntingBow);
        Mage wizard = new Mage("Gandalf The Wise", mageStaff);
        knight.PrintStatsInfo();
        wizard.PrintStatsInfo();

        //FindPartyMember();
        //int Gold = 5;

        /*Dictionary<string, int> ItemInvetory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };
        foreach(KeyValuePair<string, int> kvp in ItemInvetory)
        {
            if(kvp.Value < Gold)
            {
                Debug.LogFormat("You may purchase {0} and will have {1}g left over", kvp.Key, (Gold - kvp.Value));
            }
            else if(kvp.Value == Gold)
            {
                Debug.LogFormat("You could purchase {0} but you wont have any gold left over", kvp.Key);

            }
            else
            {
                Debug.LogFormat("You can not afford {0}, come back when you have at least {1} more gold", kvp.Key, (kvp.Value - Gold));
            };
            //Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }*/


        /*public void FindPartyMember()
            {
                List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
                Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

                foreach (string partyMember in QuestPartyMembers)
                {
                    Debug.LogFormat("{0} - Here!", partyMember);
                }
            }*/

    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
