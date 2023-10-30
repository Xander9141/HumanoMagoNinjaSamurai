class Ninja : Humano
{
    public Ninja(string name, int strength, int intelligence, int health, int dexterity = 75) : base(name, strength, intelligence, dexterity, health)
    {


    }

    public override int Attack(Humano target)
    {
        int damage = Dexterity;
        Random random = new Random();
        if (random.Next(1, 101) <= 20)
        {
            damage += 10; // Añade 10 puntos de daño si el 20% de probabilidad es verdadero
        }
        target.Health -= damage; // Reduce la salud del objetivo
        Console.WriteLine($"{Name} atacó a {target.Name} y causó {damage} puntos de daño.");
        return target.Health;
    }

    public void Steal(Humano target)
    {
        int damage = 5;
        target.Health -= damage;
        this.Health += damage;
    }
}