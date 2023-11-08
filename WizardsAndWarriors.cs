using System;

abstract class Character
{
    private readonly string CharacterType;
    protected Character(string characterType)
    {
        CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }
}

class Wizard : Character
{
   private bool PreparedSpell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override bool Vulnerable()
    {
        return PreparedSpell == false;
    }

    public override int DamagePoints(Character target)
    {
        if (PreparedSpell)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        PreparedSpell = true;
    }
}
