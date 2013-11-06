using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DiscreteMaths;
using PostSharp.Aspects;
using PostSharp.Aspects.Advices;

namespace Playground
{





    class Program
    {
        static void Main(string[] args)
        {

           // Expression.Lambda(Expression.Add(null,null)).Compile().DynamicInvoke()
           // var x = Int16.MaxValue -(short)1;

         
           //ar x =  BinaryExpression.Add(Expression.Constant(1), Expression.Constant(2));

            var x = 123;

            Console.WriteLine(x.GetType().GetInterfaces().Select(y => y.Name).Aggregate((a,b) => a+", "+b));

            Console.Write("done");
            Console.Read();
        }
    }
}
