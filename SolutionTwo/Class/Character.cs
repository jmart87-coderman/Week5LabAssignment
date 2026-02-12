using UnityEngine;

public class Character
{
    // main character base, everything inherits from here.
    // basic variables should be in character class
    public string name;
    public int level;
    public int ConScore;
    public string race;
    public string Character_Class;
    
    public bool hasTough;
    public bool hasStout;
    public bool Avg_or_rolled; // Average if true, rolled if false


    public Character()
    {

    }
    public Character (string name, int level, int conScore, string race, string Character_Class, bool hasTough, bool hasStout, bool Avg_or_rolled)
    {
        this.name = name;
        this.level = level;
        this.ConScore = conScore;
        this.race = race;
        this.Character_Class = Character_Class;
        this.hasTough = hasTough;
        this.hasStout = hasStout;
        this.Avg_or_rolled = Avg_or_rolled;
    }

    private void CalculateHP()
    {
        
    }

    void Calculate_ConScore()
    {

    }

}





