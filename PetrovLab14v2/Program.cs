using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab14v2
{
    class Program
    {
		//Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
		//абстрактное свойство - название животного.
		//В классе Animal нужно определить следующие методы:
		//конструктор, устанавливающий значение по умолчанию для названия;
		//абстрактный метод Say(), который выводит звук, который издает животное;
		//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
		//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
		//свойство – название животного;
		//метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
		//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
		// 
		// Жаль, что лекция содержит ограниченную информацию. Для выполнения задания приходится много времени отводить изучению других источников.

		static void Main(string[] args)
        {
			Cat cat = new Cat();
			cat.ShowInfo();

			Console.ReadKey();

			Dog dog = new Dog();
			dog.ShowInfo();

			Console.ReadKey();

		}
		public abstract class Animal
		{
            public Animal()
            {
                Name = "Животное";
            }

            public abstract string Name { get; protected set; }

			public abstract void Say();

			public void ShowInfo()
			{
				Console.WriteLine(Name);
				Say();
			}
		}

		public class Cat : Animal
		{
			public Cat()
			{
			}

			public override string Name
			{
				get { return "Кошка"; }
				protected set { }
			}

			public override void Say()
			{
				Console.WriteLine("Мяу");
			}
		}

		public class Dog : Animal
		{
			public override string Name
			{
				get { return "Собака"; }
				protected set { }
			}

			public override void Say()
			{
				Console.WriteLine("Гав");
			}
		}

	}
}
