using System;
using System.Collections.Generic;


class Element
{
    public int atomic_number;
    public string name;
    public string category;

    public Element(int num, string n, string c)
    {
        atomic_number = num;
        name = n;
        category = c;
    }
}

class DictDemo
{
    public static void Main(string[] args)
    {
        
        Dictionary<int, Element> elements = new Dictionary<int, Element>();

        
        elements.Add(1, new Element(1, "Hydrogen", "Nonmetal"));
        elements.Add(2, new Element(2, "Helium", "Noble Gas"));
        elements.Add(3, new Element(3, "Lithium", "Alkali Metal"));
        elements.Add(4, new Element(4, "Beryllium", "Alkaline Earth Metal"));
        elements.Add(5, new Element(5, "Boron", "Metalloid"));
        elements.Add(6, new Element(6, "Carbon", "Nonmetal"));
        elements.Add(7, new Element(7, "Nitrogen", "Nonmetal"));
        elements.Add(8, new Element(8, "Oxygen", "Nonmetal"));
        elements.Add(9, new Element(9, "Fluorine", "Halogen"));
        elements.Add(10, new Element(10, "Neon", "Noble Gas"));
        elements.Add(11, new Element(11, "Sodium", "Alkali Metal"));
        elements.Add(12, new Element(12, "Magnesium", "Alkaline Earth Metal"));
        elements.Add(13, new Element(13, "Aluminium", "Post-transition Metal"));
        elements.Add(14, new Element(14, "Silicon", "Metalloid"));
        elements.Add(15, new Element(15, "Phosphorus", "Nonmetal"));
        elements.Add(16, new Element(16, "Sulfur", "Nonmetal"));
        elements.Add(17, new Element(17, "Chlorine", "Halogen"));
        elements.Add(18, new Element(18, "Argon", "Noble Gas"));
        elements.Add(19, new Element(19, "Potassium", "Alkali Metal"));
        elements.Add(20, new Element(20, "Calcium", "Alkaline Earth Metal"));
        elements.Add(21, new Element(21, "Scandium", "Transition Metal"));
        elements.Add(22, new Element(22, "Titanium", "Transition Metal"));
        elements.Add(23, new Element(23, "Vanadium", "Transition Metal"));
        elements.Add(24, new Element(24, "Chromium", "Transition Metal"));
        elements.Add(25, new Element(25, "Manganese", "Transition Metal"));
        elements.Add(26, new Element(26, "Iron", "Transition Metal"));
        elements.Add(27, new Element(27, "Cobalt", "Transition Metal"));
        elements.Add(28, new Element(28, "Nickel", "Transition Metal"));
        elements.Add(29, new Element(29, "Copper", "Transition Metal"));
        elements.Add(30, new Element(30, "Zinc", "Transition Metal"));

        while (true)
        {
            Console.WriteLine("\nProvide atomic number of the element: ");
            int input = int.Parse(Console.ReadLine()!);

            if (elements.ContainsKey(input))
            {
                Element e = elements[input];

                Console.WriteLine("\nAtomic Number: {0}", e.atomic_number);
                Console.WriteLine("Name: {0}", e.name);
                Console.WriteLine("Class: {0}", e.category);
            }
            else
            {
                Console.WriteLine("Element not found...");
            }

            Console.WriteLine("\nDo you want to continue [y/n]?");
            string ans = Console.ReadLine()!;

            if (ans.ToLower() != "y")
                break;
        }

        Console.WriteLine("Thanks!");
    }
}