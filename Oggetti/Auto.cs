using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Oggetti
{
    public class Auto
    {
        //Attributi
        private int carDors;

        public int CarDors {  get; }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
        }

        private string plate;
        private float maxTankCapacity;

        //Stati
        private bool engineOn;
        private float currentTankLiters;

        //Costruttori
        public Auto(int doorNumber, string color, float tankCapacity)
        {
            this.carDors = doorNumber;
            this.color = color;
            this.maxTankCapacity = tankCapacity;

            this.engineOn = false;
            this.currentTankLiters = 0;
        }

        public Auto(int doorNumber, string color, string plate, float tankCapacity)
        {
            this.carDors = doorNumber;
            this.color = color;
            this.plate = plate;
            this.maxTankCapacity = tankCapacity;

            this.engineOn = false;
            this.currentTankLiters = 0;
        }

        //Getters
        public string GetColor()
        {
            return this.color;
        }

        public float GetCurrentTankLiters()
        {
            return this.currentTankLiters;
        }

        //Setters

        //Metodi
        public void PowerOn()
        {
            if (this.currentTankLiters > 0)
            {
                this.engineOn = true;
                Console.WriteLine("WWRROOOOOMM!");
            } else
            {
                Console.WriteLine("Serbatoio vuoto!");
            }
        }

        public void PowerOff()
        {
            this.engineOn = false;
            Console.WriteLine("ZZzzzzzzz");
        }

        public bool IsCarOn()
        {
            return this.engineOn;
        }

        public void FillTank(int liters)
        {
            if (currentTankLiters + liters > maxTankCapacity)
            {
                currentTankLiters = maxTankCapacity;
            } else
            {
                currentTankLiters += liters;
            }
        }

        public void FillMaxTank()
        {
            this.currentTankLiters = this.maxTankCapacity;
        }

        public void Repaint(string newColor)
        {
            switch (newColor)
            {
                case "blu":
                case "rosso":
                case "giallo":
                case "verde":
                    this.color = newColor; 
                    break;
                default:
                    Console.WriteLine("Il colore che hai impostato non è disponibile!");
                    break;
            }
        }
    }
}
