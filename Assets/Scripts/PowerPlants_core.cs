using UnityEngine;


enum  type{ coal, wind, water, atomic, solar, gas }
[CreateAssetMenu(fileName = "gameobject", menuName = "Powerplants/PowerPlants_core", order = 2)] 
public class PowerPlants_core : ScriptableObject
{
    [SerializeField] private string description;
    [SerializeField] private bool isRenewable;
    [SerializeField] private type type;
    [SerializeField] private int cost;
    [SerializeField] private int liked;

    [SerializeField] private int polution;
    [SerializeField] private int resoureceUsage;
    [SerializeField] private Mesh Object;


    void Awake()
    {
        if(type == type.wind || type == type.solar || type == type.water)
        {
            isRenewable = true;
        }
        else
        {
            isRenewable = false;            
        }
    }
}
