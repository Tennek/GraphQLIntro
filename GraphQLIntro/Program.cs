using GraphQLIntro.Ex1;
using GraphQLIntro.Ex2;
using GraphQLIntro.Ex3;
using GraphQLIntro.Ex4;
using GraphQLIntro.Ex5;
using GraphQLIntro.Ex6;
using System;
using System.Threading.Tasks;

namespace GraphQLIntro
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*example 1*/
            //await Example1.HelloWorldExample();

            /*example 2*/
            //await Example2.HelloWorldExample();

            /*example 3*/
            //await Example3.WithObject();

            /*example 4*/
            //await Example4.WithList();

            /*example 5*/
            //await Example5.WithComplexList();

            /*example 6*/
            await Example6.WithFetchById();

            Console.ReadLine();
        }
    }
}
