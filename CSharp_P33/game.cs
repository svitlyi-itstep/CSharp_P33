using System.ComponentModel;

namespace Game
{
    
    class Character
    {
        string? name;
        int health;
        int damage;
        int defence;


        public int Health
        {
            get { return this.health; }
            set { this.health = Math.Max(value, 0); }
        }

        public Character(string name, int health, int damage, int defence) { 
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.defence = defence;
        }
        
        public Character() {
            this.name = "Jonny";
            this.health = 100;
            this.damage = 5;
            this.defence = 0;
        }

        public int GetHealth()
        {
            return this.health;
        }
        public void SetHealth(int health)
        {
            this.health = Math.Max(health, 0);
        }

        public void Print()
        {
            Console.WriteLine($" -< {this.name} >-");
            Console.WriteLine($" Здоров\'я: {this.health}");
            Console.WriteLine($" Шкода: {this.damage}");
            Console.WriteLine($" Захист: {this.defence}");
        }

        public int TakeDamage( int damage )
        {
            this.health = Math.Max(this.health - damage, 0);
            return this.health;
        }

        public int Attack(Character target)
        {
            Random rnd = new Random(Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds()));
            int final_damage = Math.Max(this.damage + rnd.Next(-3, 3), 0);
            target.TakeDamage(final_damage);
            return final_damage;
        }
        
        public bool IsAlive()
        {
            return this.health > 0;
        }
    }
}
