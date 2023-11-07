// See https://aka.ms/new-console-template for more information

//Класс родитель героев

using System.Runtime.CompilerServices;
/*!
    \brief Родительский класс, в котором перечислены все основные параметры
    
    В данном классе указываются основные параметры, при помощи которых
    можно расчитать урон, хп и броню героя
*/
public class Hero
{
    int lvl;
    int hp;
    int damage;
    int armor;

    public Hero (int lvl, int hp, int damage, int armor)
    {
        this.lvl = lvl;
        this.hp = hp;
        this.damage = damage;
        this.armor = armor;
    }

/*!
    \brief Выводит хп героя
*/

    public int GetHp()
    {
        return hp;
    }

/*!
    \brief Выводит броню героя
*/

    public int GetArmor()
    {
        return lvl*armor;
    }
}

// Подкласс "Воин"

/*!
    \brief Подкласс "Воин"

    Этот подкласс имеет дополнительные методы, которые могут изменить
    характеристики урон, хп или броня
*/
public class Warrior : Hero
{
    int lvl;
    int hp;
    int damage;
    int armor;

    public Warrior (int lvl, int hp, int damage, int armor) : base (lvl, hp, damage, armor)
    {
        this.lvl = lvl;
        this.hp = hp;
        this.damage = damage;
        this.armor = armor;
    }

    /*!
        \brief Увеличивает урон героя в 5 раз
    */

    public int GetMoreDamage()
    {
        return lvl*damage*5;
    }

}


//Класс родитель щитов

/*!
    \brief Класс щиты

    В щитах перечисляются параметры, которые в будущем можно суммировать с защитой героя
*/
public class Shield : IComparable<Shield>
{
    string type;
    int armor;
    int price;

    public Shield (string type, int armor, int price)
    {
        this.type = type;
        this.armor = armor;
        this.price = price;
    }

    /*!
        \brief Интерфейс сортировки щитов по броне
    */

    public int CompareTo(Shield? s)
    {
        if (s is null) throw new ArgumentException("Некорректные данные");
        return s.armor - armor;
        }
        /*!
        \brief Выводит цену щита
        */
    public int GetPrice()
    {
        return price;
    }

    /*!
        \brief Выводит броню щита
    */

    public int GetArmor()
    {
        return armor;
    }

    /*!
        \brief Выводит тип щита
    */

    public string GetType()
    {
        return type;
    }
}

//Подкласс "Тяжёлый щит"

/*!
    \brief Подкласс "Тяжёлый щит"

    Этот подкласс имеет дополнительные методы, которые могут изменить
    характеристики урона и брони
*/

public class HeavyShield : Shield
{
    string type;
    int armor;
    int price;
    int damage;

    public HeavyShield (string type, int armor, int damage, int price) : base (type, armor, price)
    {
        this.type = type;
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

/*!
    \brief Подкласс "Лёгкий щит"

    Этот подкласс имеет дополнительные методы, которые могут изменить
    характеристики урона и брони
*/

public class LiteShield : Shield
{
    string type;
    int armor;
    int price;

    public LiteShield(string type, int armor, int price) : base (type, armor, price)
    {
        this.type = type;
        this.armor = armor;
        this.price = price;
    }

    public int SpecialSpellArmor()
    {
        return armor+10;
    }
}


//Класс для запуска кода

/*!
    \brief Класс в котором запускаются процессы кода
*/

public class Start
{
    public static void Main()
    {
        Warrior warrior = new Warrior(31, 16, 43, 23);
        LiteShield shield1 = new LiteShield("Лёгкий", 13, 1265);
        LiteShield shield2 = new LiteShield("Лёгкий", 1343, 12653214);
        HeavyShield shield3 = new HeavyShield("Тяжёлый", 124124, 123123, 321423);

        Shield[] shields = {shield1, shield2, shield3};

        int allArmor = warrior.GetArmor() + shield1.SpecialSpellArmor();

        Array.Sort(shields);

        foreach(Shield shield in shields)
        {
            Console.WriteLine(
                $"Тип:{shield.GetType()} Броня:{shield.GetArmor()} Цена:{shield.GetArmor()}"
            );
        }
        Console.WriteLine("Hp: " + warrior.GetHp());
        Console.WriteLine("Armor: " + allArmor);
        Console.WriteLine("Damage: " + warrior.GetMoreDamage());
    }
}