using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__19._09._22_
{
    delegate void myDelegate(string _str);
    class PC
    {
        public string Name;
        private string nameOfDisplay, nameOfPCBox, nameOfKeyboard, nameOfMouse,
            empty = "<none>";
        public myDelegate myAction;

        public PC()
        {
            Console.WriteLine("Введите имя ПК : ");
            Name = Console.ReadLine();
            nameOfDisplay = nameOfPCBox = nameOfKeyboard = nameOfMouse = empty;
        }
        public void PC_menu(int _number, string _name)
        {
            if (_number == 1)
            {
                myAction += addDisplay;
                Print(_name);
            }
        }
        private void Print(string _text)
        {
            myAction(_text);
        }
        public void addDisplay(string nameOfDisplay)
        {
            this.nameOfDisplay = nameOfDisplay;
            Console.WriteLine("К рабочему месту добавлен монитор {0}.", nameOfDisplay);
            
        }
        public void minusDisplay(string nameOfDisplay)
        {
            if (this.nameOfDisplay == nameOfDisplay)
            {
                this.nameOfDisplay = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfDisplay);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfDisplay);
            }
            

        }
        public void addPCBox(string nameOfPCBox)
        {
            this.nameOfPCBox = nameOfPCBox;
            Console.WriteLine("К рабочему месту добавлен системный блок {0}.", nameOfPCBox);
        }
        public void addKeyboard(string nameOfKeyboard)
        {
            this.nameOfKeyboard = nameOfKeyboard;
            Console.WriteLine("К рабочему месту добавлена клавиатура {0}.", nameOfKeyboard);
        }
        public void addMouse(string nameOfMouse)
        {
            this.nameOfMouse = nameOfMouse;
            Console.WriteLine("К рабочему месту добавлена мышь {0}.", nameOfMouse);
        }
        

    }
}
