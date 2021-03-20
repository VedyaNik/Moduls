using System;
using Delegat;
using static Delegat.Delegates;

class Program
    {

        static void Main(string[] args)
        {
        Count function = DelFuncInc(functionSum, functionDif);
        function = DelFuncInc(function, functionDif);
        function = DelFuncInc(function, functionProd);
        function = DelFuncDec(function, functionDif);
        function = DelFuncInc(function, functionProd);
        function = DelFuncInc(function, functionDiv);
        function = DelFuncDec(function, functionProd);
        function(15, 3);
    }
    }
