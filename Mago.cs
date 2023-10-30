class Mago : Humano
{
    public Mago(string name, int strength, int intelligence, int dexterity, int health = 50) : base(name, strength, intelligence, dexterity, health)
    {
        health = 50; // Valor por defecto de la salud
        intelligence = 25; // Valor por defecto de la inteligencia
    }

    public override int Attack(Humano target)
    {
        int damage = Intelligence * 3;
        target.Health -= damage;
        Health += damage; // Sanar el Mago por el daño infligido
        Console.WriteLine($"{Name} atacó a {target.Name} y causó {damage} puntos de daño. El Mago se curó {damage} puntos de salud.");
        return target.Health;
    }

    public void Heal(Humano target){
        if (target != null && target is Humano)
        {
        target.Health += Intelligence * 3;
        Console.WriteLine($"{Name} ha curado a {target.Name} por {Intelligence * 3} puntos de salud.");
    }
    else
    {
        Console.WriteLine("El objetivo no es válido para curación.");
    }

    
}
}