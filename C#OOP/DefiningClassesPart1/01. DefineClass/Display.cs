﻿namespace DefineClass
{
    using System;

    /// <summary>
    /// Mobile phone display. Warning: defaul color is count as color - if you set colors = 1 you can expect exception!
    /// All fields are nulalble
    /// </summary>
    public class Display
    {
        private double? size;

        private int? colors;

        //cannot make display if dont know its size 
        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int colors)
            : this(size)
        {
            this.Colors = colors;
        }

        public double Size
        {
            get
            {
                return (double)this.size;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be zero or negative. IF display is broken use Repair()");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int Colors
        {
            get
            {
                return (int)this.colors;
            }
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Displays with less then 2 colors is \"broken\". Please use Repair()");
                }
                this.colors = value;
            }
        }

        // just a joke
        public void Repair()
        {
            throw new InvalidOperationException("The display cannot be repaired. Just buy new.");
        }

        public override string ToString()
        {
            return String.Format("Size: {0}inches{1} {2}",
                this.size.ToString(),
                Environment.NewLine,
                this.colors == null ? string.Empty : String.Format("Colors: {0}", this.colors.ToString())).Trim();
        }
    }
}