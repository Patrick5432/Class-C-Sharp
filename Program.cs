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


public class Hero {
    int lvl;
    int armor;
    int damage;

    public Hero(int lvl, int armor, int damage) {
        this.lvl = lvl;
        this.armor = armor;
        this.damage = damage;
    }

    public int GetDamage() {
        return lvl * damage;
    }

    public int GetArmor() {
        return armor;
    }
}

public class Simple {
    public static void Main() {
        Hero firstHero = new Hero(2, 13, 12);
        Console.WriteLine("Урон: " + firstHero.GetDamage() + " Защита: " + firstHero.GetArmor());
    }
}