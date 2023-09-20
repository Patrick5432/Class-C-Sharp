// See https://aka.ms/new-console-template for more information
// public class Person {
//     string name;
//     string age;

//     public Person(string name, string age) {
//         this.name = name;
//         this.age = age;
//     }

//     public string NameAndAge() {
//         return name + " " + age;
//     }
// }

// public class Simple {
//     public static void Main() {
//         Person human = new Person("1", "2");
//         Console.WriteLine(human.NameAndAge());
//     }
// }

// =========================================================

// public class Hero {
//     int lvl;
//     int armor;
//     int damage;

//     public Hero(int lvl, int armor, int damage) {
//         this.lvl = lvl;
//         this.armor = armor;
//         this.damage = damage;
//     }

//     public int GetDamage() {
//         return lvl * damage;
//     }

//     public int GetArmor() {
//         return armor;
//     }
// }

// public class Simple {
//     public static void Main() {
//         Hero firstHero = new Hero(2, 13, 12);
//         Console.WriteLine("Урон: " + firstHero.GetDamage() + " Защита: " + firstHero.GetArmor());
//     }
// }

// =========================================================


//Класс родитель

public class Shield
{
    int armor;
    int price;

    public Shield (int armor, int price)
    {
        this.armor = armor;
        this.price = price;
    }

    public int GetPrice()
    {
        return price;
    }
}

//Подкласс "Тяжёлый щит"

public class HeavyShield : Shield
{
    int armor;
    int price;
    int damage;

    public HeavyShield (int armor, int damage, int price) : base (armor, price)
    {
        this.armor = armor;
        this.damage = damage;
        this.price = price;
    }

    public int SpecialSpell()
    {
        return armor*damage;
    }
}

//Подкласс "Лёгкий щит"

public class LiteShield : Shield
{
    int armor;
    int price;

    public LiteShield(int armor, int price) : base (armor, price)
    {
        this.armor = armor;
        this.price = price;
    }

    public int SpecialSpellArmor()
    {
        return armor+10;
    }
}

public class Start
{
    public static void Main()
    {
        LiteShield shield = new LiteShield(13, 1265);
        Console.WriteLine(shield.SpecialSpellArmor());
    }
}













// //Подкласс "Тяжёлый щит"

// public class HeavyShield : Shield {

//     int damage;

//     public HeavyShield(int armor, int damage, int price) : base (armor, price) {
//         this.armor = armor;
//         this.damage = damage;
//         this.price = price;
//     }
    
//     public int SpecialSpell() {
//         Console.WriteLine("1231");
//         return armor * damage;
//     }
// }

// //Подкласс "Лёгкий щит"

// public class LiteShield : Shield {
//     int armor;
//     int price;

//     public LiteShield(int armor, int price) {
//         this.armor = armor;
//         this.price = price;
//     }

//     public int SpecialSpellLite() {
//         return armor + 10;
//     }
// }

// //Класс для запуска

// public class Simple {
//     public static void Main() {
//         HeavyShield Hero = new HeavyShield(12, 31, 32);
//         Console.WriteLine(Hero.SpecialSpell());
//     }
// }