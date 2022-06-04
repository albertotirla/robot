namespace Environment;
abstract public class Planet
{
    public List<ITargetable> Population { get; }
    public bool ContainsLife
    {
        get
        {
            bool SomethingAlive = true;
            foreach (var entity in Population)
            {
                if (entity.IsAlive) SomethingAlive = true;
            }
            return SomethingAlive;
        }
    }

    public Planet(int MaximumPopulation)
    {
        Population = new();
        for (int i = 0; i < MaximumPopulation; i++)
        {
            Random rng = new();
            int which = rng.Next(3);
            ITargetable entityToAdd = which switch
            {
                0 => new Human(),
                1 => new Animal(),
                _ => new SuperHero(),
            };
            Population.Add(entityToAdd);
        }
    }
}
    