namespace CSharpFundamental1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "Toan",
                    LastName = "Ngo Huu",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 12, 11),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Nam",
                    IsGraduated = true
                },
                new Member{
                    FirstName = "Tuan",
                    LastName = "Nguyen Van",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1996, 10, 11),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nhung",
                    LastName = "Nguyen Thi",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2000, 02, 21),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Noi",
                    IsGraduated = true
                }
            };

            Console.WriteLine("Cau 1");
            int max = 0;
            foreach (var member in members)
            {
                if (member.Gender != "Male")
                {
                    continue;
                }

                if (max < member.Age)
                {
                    max = member.Age;
                }

                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Cau 2");
            foreach (var member in members)
            {
                if (member.Age == max)
                {
                    Console.WriteLine(member.Info);
                    break;
                }
            }

            Console.WriteLine("Cau 3");
            foreach (var member in members)
            {
                Console.WriteLine(member.FullName);
            }

            Console.WriteLine("Cau 4");
            List<Member> Age2000 = new List<Member>();
            List<Member> AgeLess2000 = new List<Member>();
            List<Member> AgeMore2000 = new List<Member>();

            foreach (var member in members)
            {
                switch (member.DateOfBirth.Year == 2000)
                {
                    case true:
                        Age2000.Add(member);
                        break;
                    default:
                        switch (member.DateOfBirth.Year < 2000)
                        {
                            case true:
                                AgeLess2000.Add(member);
                                break;
                            default:
                                AgeMore2000.Add(member);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine("List member birth year is 2000 :");
            foreach (var member in Age2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List member birth year less 2000 :");
            foreach (var member in AgeLess2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List member birth year more 2000 :");
            foreach (var member in AgeMore2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Cau 5");
            int positionPointer = 0;
            while (positionPointer < members.Count)
            {
                if (members[positionPointer].BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(members[positionPointer].Info);
                    break;
                }

                positionPointer++;
            }
        }
    }
}
