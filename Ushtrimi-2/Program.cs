internal class Program
{
    private static void Main(string[] args)
    {
       Employee employee = new  Employee(1,"Yll",Pozitat.Zhvillues,1200);
      ;

        Employee dielli = new Employee(2, "Diell", Pozitat.Menaxher, 2000);
      
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


            Console.WriteLine(id + ". Emri: " + emri + " Pozita: " + pozita + " Rroga: " + Rroga+" Bonusi: "+CalculateBonus(Rroga));
        }

        public int CalculateBonus(double rroga)
        {
            double bonus = 0;
            if (Pozita == Pozitat.Zhvillues)
            {
                bonus = rroga * .20;
            }
            else if (Pozita == Pozitat.Admin)
            {
                bonus = rroga + 50000;
            }
            else if (Pozita == Pozitat.Menaxher)
            {
                bonus = rroga * .25;
            }
            return (int)bonus;
        }


    }
}