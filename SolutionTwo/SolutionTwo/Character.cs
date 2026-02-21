using UnityEngine;


public abstract class Character
{
    // main character base, everything inherits from here.
    // basic variables should be in character class
    public string name;
    public int level;
    public int ConScore;
    public int hitDie;
    // character class variable is not needed as they are all separate classes.
    public Race race;
    public bool hasTough;
    public bool hasStout;
    public bool Avg_or_rolled; // Average if true, rolled if false
    public int HP;


    protected Character (string name, int level, int conScore, Race race, int hitDie, bool hasTough, bool hasStout, bool Avg_or_rolled)
    {
        this.name = name;
        this.level = level;
        this.ConScore = conScore;
        this.race = race;
        this.hitDie = hitDie;
        this.hasTough = hasTough;
        this.hasStout = hasStout;
        this.Avg_or_rolled = Avg_or_rolled;

        HP = CalculateHP();
    }

    private int CalculateHP() // Function to calculate HP
    {
        int ConBuff = Mathf.FloorToInt((ConScore - 10) / 2f); // calculates Constitution modifier

        int totalHP = 0;

        for (int i = 1; i <= level; i ++) // adds die per level 
        {
            if (Avg_or_rolled)
            {
                totalHP += (hitDie / 2) + 1 + ConBuff; // adds average die roll and constitution modifier to total HP
            }
            else
            {
                totalHP += Random.Range(1, hitDie + 1) + ConBuff; // adds random die roll and constitution modifier to total HP
            }

        }

        totalHP += race.HPBonus * level;

        if (hasTough)
            {
                totalHP += 2 * level; // adds 2 HP per level if character has Tough feat
            }
        if (hasStout)
            {
                totalHP += 1 * level; // adds 1 HP per level if character has Stout racial trait
            }
            
        return totalHP;
        
        
    }

    

}





