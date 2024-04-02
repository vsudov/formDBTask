using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ks_21_2_Dubinkin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAuth = false;
            bool isHaveAccount = false;
            string login = "";
            string password = "";

            bool isHaveForm = false;

            //Form data
            string name = null,
                surname = null,
                email = null;
            int yearsOld = 0;

            while (true) { 
                if (isAuth)
                {
                    int command,
                        type;

                    Console.WriteLine("1 - Создать анкету\n2 - Изменить анкету\n3 - Вывести анкету\n4 - изменить логин или пароль\n5 - Выход");
                    Console.Write("Выберите команду:\t");
                    command = Convert.ToInt32(Console.ReadLine());

                    switch (command) {
                        case 1:
                            if (isHaveForm) Console.WriteLine("У Вас уже есть анкета!");
                            else
                            {
                                Console.Write("Введите имя:\t");
                                name = Console.ReadLine();
                                Console.Write("Введите фамилию:\t");
                                surname = Console.ReadLine();
                                Console.Write("Введите возраст:\t");
                                yearsOld = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите эл. почту:\t");
                                email = Console.ReadLine();

                                isHaveForm = true;
                                Console.WriteLine("Анкета создана и заполнена!");
                            }
                            Console.Clear();
                            break;
                        case 2:
                            if (!isHaveForm) Console.WriteLine("У Вас нет анкеты!");
                            else
                            {
                                Console.WriteLine("1 - Имя\n2 - Фамилию\n3 - Возраст\n4 - Эл. почту");
                                Console.Write("Выберите чего хотите изменить:\t");
                                type = Convert.ToInt32(Console.ReadLine());

                                switch(type)
                                {
                                    case 1:
                                        Console.Write("Введите имя:\t");
                                        name = Console.ReadLine();
                                        Console.WriteLine("Данные изменены.");
                                        break;
                                    case 2:
                                        Console.Write("Введите фамилию:\t");
                                        surname = Console.ReadLine();
                                        Console.WriteLine("Данные изменены.");
                                        break;
                                    case 3:
                                        Console.Write("Введите возраст:\t");
                                        yearsOld = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Данные изменены.");
                                        break;
                                    case 4:
                                        Console.Write("Введите эл. почту:\t");
                                        email = Console.ReadLine();
                                        Console.WriteLine("Данные изменены.");
                                        break;
                                }
                            }
                            Console.Clear();
                            break;

                        case 3:
                            if (!isHaveForm) Console.WriteLine("У Вас нет анкеты!");
                            else
                            {
                                Console.WriteLine($"Анкета:\nИмя:\t{name}\nФамилия:\t{surname}\nВозраст:\t{yearsOld}\nЭл. почта:\t{email}");
                            }
                            break;

                        case 4:
                            Console.WriteLine("1 - Изменить логин\n2 - Изменить пароль");
                            Console.Write("Выберите чего хотите изменить:\t");
                            type = Convert.ToInt32(Console.ReadLine());

                            switch(type)
                            {
                                case 1:
                                    Console.Write("Введите новый логин:\t");
                                    login = Console.ReadLine();
                                    Console.WriteLine("Логин изменён.");
                                    break;
                                case 2:
                                    Console.Write("Введите новый пароль:\t");
                                    password = Console.ReadLine();
                                    Console.WriteLine("Пароль изменён.");
                                    break;
                            }
                            Console.Clear();
                            break;
                    }

                    if(command == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Выход из программы выполнен.");
                        break;
                    }
                }
                else
                {
                    string loginInput;
                    string passwordInput;

                    if (isHaveAccount)
                    {
                        Console.WriteLine("Вы не авторизованы! Чтобы продолжить авторизируйтесь!");

                        while(true) {
                            Console.Write("Введите логин:\t");
                            loginInput = Console.ReadLine();
                            Console.Write("Введите пароль:\t");
                            passwordInput = Console.ReadLine();

                            if(loginInput == login && passwordInput == password)
                            {
                                Console.WriteLine("Вы авторизировались.");
                                isAuth = true;
                                break;
                            }
                            else Console.WriteLine("Не правильно введен пароль!");
                        }

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("У Вас нет аккаунта! Чтобы продолжить зарегистрируйтесь!");

                        while (true)
                        {
                            Console.Write("Введите логин:\t");
                            loginInput = Console.ReadLine();
                            Console.Write("Введите пароль:\t");
                            passwordInput = Console.ReadLine();

                            if (loginInput == null || passwordInput == null)
                            {
                                Console.WriteLine("Пароль или логин не могут быть пустыми.");                                
                            }
                            else
                            {
                                Console.WriteLine("Вы зарегистрировались.");

                                login = loginInput;
                                password = passwordInput;

                                isHaveAccount = true;
                                break;
                            }
                        }

                        Console.Clear();
                    }
                }
            }

            
        }
    }
}
