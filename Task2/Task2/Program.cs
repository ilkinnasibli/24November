class ClassTask
{
    public static void Main()
    {

        try
        {
            Students student = new("ilkin", "nasibli", "1122333333");
        }
        catch (InvalidGroupNoException exp)
        {
            Console.WriteLine(exp.Message);
        }



    }
}

public class Students
{
    private int id;
    private string Name;
    private string Surname;
    private string GroupNo;
    private static int _id;
    public Students(string name, string surname, string groupNo)
    {

        Name = name;
        Surname = surname;
        GroupNo = groupNo;
        _id;
        id = _id;
    }

    public string GroupNoProperty
    {
        get
        {
            return GroupNo;
        }
        set
        {
            CheckGroupNo check = new();


            if (check.CheckGroupNoFunc(value))
            {
                GroupNo = value;
            }
            else
            {
                throw new InvalidGroupNoException("Invalid Group exception");
            }
        }
    }

    public string StudentInfo()
    {
        return $"Name: {Name}\n Surname: {Surname}\n GroupNo: {GroupNo}\n id:{id}";
    }

}

public class CheckGroupNo
{
    public bool CheckGroupNoFunc(string value)
    {
        int nums = 0;
        int letters = 0;
        for (var i = 0; i < value.Length; i)
        {
            if (char.IsDigit(value[i]))
            {
                nums;
            }
            else if (char.IsUpper(value[i]))
            {
                letters;
            }
        }

        if (nums != 3 && letters != 2)
        {
            return false;
        }
        return true;
    }
}

class InvalidGroupNoException : Exception
{
    public InvalidGroupNoException(string message) : base(message)
    {
    }
}
