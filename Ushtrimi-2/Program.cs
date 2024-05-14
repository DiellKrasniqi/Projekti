internal class Program
{
    private static void Main(string[] args)
    {
        Employee ylli = new Employee(1, "Yll", Pozitat.Zhvillues, 26000);
        Employee dielli = new Employee(2, "Diell", Pozitat.Menaxher, 800000);
        Employee Agimi = new Employee(3, "Agim", Pozitat.Admin, 4500);

    }

    public enum Pozitat
    {
        Zhvillues,
        Menaxher,
        Admin
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public Pozitat Pozita { get; set; }
        public double Rroga { get; set; }

        public Employee(int id, string emri, Pozitat pozita, double rroga)
        {
            this.Id = id;
            this.Emri = emri;
            this.Pozita = pozita;
            this.Rroga = rroga;


            Console.WriteLine(id + ". Emri: " + emri + " Pozita: " + pozita + " Rroga: " + Rroga + " Bonusi: " + CalculateBonus(Rroga));
        }


        public double CalculateBonus(double rroga)
        {
            double bonus = 0;
            if (Pozita == Pozitat.Zhvillues)
            {
                double a = rroga * .20;
                if (5000 > a)
                {
                    bonus = 5000;
                }
                else if (5000 < a)
                {
                    bonus = a;
                }
            }
            else if (Pozita == Pozitat.Admin)
            {
                bonus = 5000;
            }
            else if (Pozita == Pozitat.Menaxher)
            {
                double b = rroga * .25;
                if (5000 > bonus)
                {
                    bonus = 5000;
                }
                else if (5000 < bonus)
                {
                    bonus = b;
                }
            }
            return bonus;
        }


    }
}