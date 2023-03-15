namespace Hillel_Lesson2_HW;

public class Animal
{

    protected string _typeOfAnimal;
    protected string _name;
    protected int _age;
    protected int _oxygenLevel;

    internal string TypeOfAnimal
    {
        get
        {
            return _typeOfAnimal;
        }
        
    }
    internal string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    

    internal int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                _age = 0;
            }
        }
    }

    public int OxygenLevel
    {
        get
        {
            return _oxygenLevel;
        }
        set
        {
            _oxygenLevel = value;
        }
    }


    public Animal(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public Animal()
    {
        
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("");
    }








}