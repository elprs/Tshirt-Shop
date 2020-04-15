using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy
{
    class MyDatabase
    {

        public List<Tshirt> tshirts { get; set; } = new List<Tshirt>();

        public MyDatabase()
        {

            Tshirt tshirt1 = new Tshirt(Color.Blue, Size.L, Fabric.Casmere);
            Tshirt tshirt2 = new Tshirt(Color.Green, Size.XS, Fabric.Cotton);
            Tshirt tshirt3 = new Tshirt(Color.Indigo, Size.XS, Fabric.Liner);
            Tshirt tshirt4 = new Tshirt(Color.Orange, Size.S, Fabric.Rayon);
            Tshirt tshirt5 = new Tshirt(Color.Indigo, Size.M, Fabric.Polyester);
            Tshirt tshirt6 = new Tshirt(Color.Indigo, Size.XL, Fabric.Cotton);
            Tshirt tshirt7 = new Tshirt(Color.Blue, Size.L, Fabric.Casmere);
            Tshirt tshirt8 = new Tshirt(Color.Orange, Size.XXL, Fabric.Polyester);
            Tshirt tshirt9 = new Tshirt(Color.Orange, Size.S, Fabric.Rayon);
            Tshirt tshirt10 = new Tshirt(Color.Red, Size.XS, Fabric.Liner);
            Tshirt tshirt11 = new Tshirt(Color.Red, Size.XS, Fabric.Wool);
            Tshirt tshirt12 = new Tshirt(Color.Blue, Size.L, Fabric.Polyester);
            Tshirt tshirt13 = new Tshirt(Color.Orange, Size.M, Fabric.Silk);
            Tshirt tshirt14 = new Tshirt(Color.Violet, Size.L, Fabric.Cotton);
            Tshirt tshirt15 = new Tshirt(Color.Yellow, Size.M, Fabric.Liner);
            Tshirt tshirt16 = new Tshirt(Color.Orange, Size.S, Fabric.Casmere);
            Tshirt tshirt17 = new Tshirt(Color.Blue, Size.L, Fabric.Polyester);
            Tshirt tshirt18 = new Tshirt(Color.Yellow, Size.XS, Fabric.Rayon);
            Tshirt tshirt19 = new Tshirt(Color.Violet, Size.XL, Fabric.Cotton);
            Tshirt tshirt20 = new Tshirt(Color.Blue, Size.XXXL, Fabric.Liner);
            Tshirt tshirt21 = new Tshirt(Color.Orange, Size.L, Fabric.Liner);
            Tshirt tshirt22 = new Tshirt(Color.Blue, Size.L, Fabric.Wool);
            Tshirt tshirt23 = new Tshirt(Color.Indigo, Size.XXXL, Fabric.Rayon);
            Tshirt tshirt24 = new Tshirt(Color.Yellow, Size.XS, Fabric.Polyester);
            Tshirt tshirt25 = new Tshirt(Color.Blue, Size.L, Fabric.Cotton);
            Tshirt tshirt26 = new Tshirt(Color.Violet, Size.XL, Fabric.Silk);
            Tshirt tshirt27 = new Tshirt(Color.Violet, Size.S, Fabric.Silk);
            Tshirt tshirt28 = new Tshirt(Color.Orange, Size.XXXL, Fabric.Rayon);
            Tshirt tshirt29 = new Tshirt(Color.Indigo, Size.S, Fabric.Cotton);
            Tshirt tshirt30 = new Tshirt(Color.Blue, Size.XL, Fabric.Liner);
            Tshirt tshirt31 = new Tshirt(Color.Violet, Size.M, Fabric.Silk);
            Tshirt tshirt32 = new Tshirt(Color.Orange, Size.XS, Fabric.Rayon);
            Tshirt tshirt33 = new Tshirt(Color.Indigo, Size.XS, Fabric.Cotton);
            Tshirt tshirt34 = new Tshirt(Color.Blue, Size.L, Fabric.Casmere);
            Tshirt tshirt35 = new Tshirt(Color.Indigo, Size.XXXL, Fabric.Polyester);
            Tshirt tshirt36 = new Tshirt(Color.Blue, Size.L, Fabric.Wool);
            Tshirt tshirt37 = new Tshirt(Color.Yellow, Size.S, Fabric.Cotton);
            Tshirt tshirt38 = new Tshirt(Color.Indigo, Size.M, Fabric.Liner);
            Tshirt tshirt39 = new Tshirt(Color.Orange, Size.XXL, Fabric.Polyester);
            Tshirt tshirt40 = new Tshirt(Color.Blue, Size.L, Fabric.Cotton);

            tshirts.Add(tshirt1);
            tshirts.Add(tshirt2);
            tshirts.Add(tshirt3);
            tshirts.Add(tshirt4);
            tshirts.Add(tshirt5);
            tshirts.Add(tshirt6);
            tshirts.Add(tshirt7);
            tshirts.Add(tshirt8);
            tshirts.Add(tshirt9);
            tshirts.Add(tshirt10);
            tshirts.Add(tshirt11);
            tshirts.Add(tshirt12);
            tshirts.Add(tshirt13);
            tshirts.Add(tshirt14);
            tshirts.Add(tshirt15);
            tshirts.Add(tshirt16);
            tshirts.Add(tshirt17);
            tshirts.Add(tshirt18);
            tshirts.Add(tshirt19);
            tshirts.Add(tshirt20);
            tshirts.Add(tshirt21);
            tshirts.Add(tshirt22);
            tshirts.Add(tshirt23);
            tshirts.Add(tshirt24);
            tshirts.Add(tshirt25);
            tshirts.Add(tshirt26);
            tshirts.Add(tshirt27);
            tshirts.Add(tshirt28);
            tshirts.Add(tshirt29);
            tshirts.Add(tshirt30);
            tshirts.Add(tshirt31);
            tshirts.Add(tshirt32);
            tshirts.Add(tshirt33);
            tshirts.Add(tshirt34);
            tshirts.Add(tshirt35);
            tshirts.Add(tshirt36);
            tshirts.Add(tshirt37);
            tshirts.Add(tshirt38);
            tshirts.Add(tshirt39);
            tshirts.Add(tshirt40);
        }
    }
}
