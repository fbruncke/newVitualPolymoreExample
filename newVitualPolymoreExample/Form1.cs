using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newVitualPolymoreExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal());
            animalList.Add(new Dog());
            animalList.Add(new Cat());          

            foreach (Animal animalItem in animalList)
            {
                animalItem.whoAreYou();
            }

            //((Cat)animalList[2]).whoAreYou();

            //Cat test = animalList[2] as Cat;
            //test?.whoAreYou();  

            //Animal testCat  = new Cat();
            //testCat.whoAreYou();

        }
    }

    class Animal
    {
        public Animal()
        { }

        public Animal(String test)
        {
            MessageBox.Show($"Testing {test}");
        }

        public virtual void whoAreYou()
        {
            MessageBox.Show("I am an animal");
        }
    }

    class Dog:Animal
    {
        public Dog() : base("Overloaded constructor")
        {            
            //base.whoAreYou();
        }

        public override void whoAreYou()
        {
            MessageBox.Show("I am a Dog");            
        }
    }

    class Cat:Animal
    {
        public new void whoAreYou()
        {
            MessageBox.Show("I am a Cat");
        }
    }
}
