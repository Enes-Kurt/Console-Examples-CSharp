namespace Çalışanın_Mesaili_Ücretini_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program şirketinizdeki işçinin sınıfını seçektikten sonra bu işçinin hafta içi ve hafta sonu mesai sürelerini girerek işçinin toplam aylık ücretini hesaplar.");
            string control = "n";
            int counter = 0;
            string[] employeeList = new string[0];
            // This while loop checks whether you want to enter new workers or not. 
            while (control == "n")
            {
                Array.Resize(ref employeeList, counter + 1);
                double employeeSalary = EmployeeSelect(out string name, out string surName);
                ReadOvertime(out int midOvertime, out int endOvertime);
                double result = TotalSalary(employeeSalary, midOvertime, endOvertime);
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                string employeeResult = ($"{name} {surName} isimli işçinin mesai ücretleri dahil toplam aylık maaşı: {result} TL");
                employeeList[counter] = employeeResult;
                counter++;
                Console.Write("\nProgramı sonlandırmak istiyor musunuz?(y/n): \n");
                control = Console.ReadLine();
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("İşçi listeniz ve ücretleri");
            Console.WriteLine("---------------------------");
            foreach (string employee in employeeList)
                Console.WriteLine(employee);
        }

        // This method selects the worker class you want to calculate.
        static double EmployeeSelect(out string name, out string surName)
        {
            double cirakSalary = 3000;
            double kalfaSalary = cirakSalary * 1.5;
            double ustaSalary = cirakSalary * 3;
            while (true)
            {
                Console.WriteLine("\nKullanıcının adını ve soyadını giriniz...");
                Console.Write("Adı: ");
                name = Console.ReadLine();
                Console.Write("Soyad: ");
                surName = Console.ReadLine();
                if (name.Length > 2 && surName.Length > 2) break;
                else Console.WriteLine("İsim ve soyisim 3 harften küçük olamaz.");
            }
            while (true)
            {
                Console.WriteLine("Maaş hesabı yapmak istediğiniz işçi sınıfını seçiniz:");
                Console.WriteLine("1- Çırak");
                Console.WriteLine("2- Kalfa");
                Console.WriteLine("3- Usta");
                Console.Write("Seçiminiz:");
                int select = 0;
                bool control = int.TryParse(Console.ReadLine(), out select);
                if (control)
                {
                    switch (select)
                    {
                        case 1: return cirakSalary;
                        case 2: return kalfaSalary;
                        case 3: return ustaSalary;
                        default:
                            Console.WriteLine("Hatalı seçim yaptınız.");
                            break;

                    }
                }
                else
                    Console.WriteLine("Hatalı seçim yaptınız.");
            }
        }
        // This method reads midweek and weekend overtime.
        static void ReadOvertime(out int midOvertime, out int endOvertime)
        {

            while (true)
            {
                int readedMidOvertime;
                int readedEndOvertime;
                Console.Write("(1 Hafta için) Hafta içi toplam mesai süresini giriniz:");
                bool midOvertimeIsInt = int.TryParse(Console.ReadLine(), out readedMidOvertime);
                Console.Write("(1 Hafta için) Hafta sonu tpolam mesai süresini giriniz:");
                bool endOvertimeIsInt = int.TryParse(Console.ReadLine(), out readedEndOvertime);

                if (midOvertimeIsInt && endOvertimeIsInt && 0 <= readedMidOvertime && readedMidOvertime <= 15 && 0 <= readedEndOvertime && readedEndOvertime <= 20)
                {
                    midOvertime = readedMidOvertime;
                    endOvertime = readedEndOvertime;
                    break;
                }
                else Console.WriteLine("\nToplam hafta içi mesai 0 ila 15 saat olabilir.\nToplam hafta sonu mesai 0 ila 20 saat olabilir.\n");
            }

        }
        //This method calculates the total salary of the worker with overtime.
        static double TotalSalary(double monthSalary, int midOvertime, int endOvertime)
        {
            double hourlySalary = monthSalary / 20 / 10;
            double midweekPrice = hourlySalary * midOvertime * 4 * 1.5;
            double weekendPrice = hourlySalary * midOvertime * 4 * 2;

            return monthSalary + midweekPrice + weekendPrice;
        }
    }
}