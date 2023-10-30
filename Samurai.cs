class Samurai : Humano
{
    public Samurai(string name, int strength, int intelligence, int dexterity, int health = 200) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Humano target)
    {
        base.Attack(target); // Llamada al método base de Attack en la clase Humano

        if (target.Health < 50)
        {
            target.Health = 0; // Reducir la salud del objetivo a 0 si tiene menos de 50 puntos de salud
            Console.WriteLine($"{Name} atacó a {target.Name} y redujo su salud a 0.");
        }

        return target.Health;
    }

    public void Meditate(){
        this.Health = 200;
    }

}