﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunLibrary
{
    // 靜態工廠方法模式
    public class PokemonFactory
    {
        public static Pokemon Create(int nationalNo)
        {
            switch (nationalNo)
            {
                case 1:
                    return new Bulbasaur();

                case 2:
                    return new Ivysaur();

                default:
                    return new Bulbasaur();
            }
        }
    }
}