using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conjur;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Conjur_POC
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
           
            Client conjurClientDave = new Client("http://localhost:8080", "myConjurAccount");
            //Login as Dave (human)
            conjurClientDave.LogIn("Dave@BotApp", "7hn96t291pdgxrsg7jyg3apcw3zn0mzm12v526b2dbbztq2d3jkjd");
            string conjurAuthToken = conjurClientDave.LogIn("Dave@BotApp", "7hn96t291pdgxrsg7jyg3apcw3zn0mzm12v526b2dbbztq2d3jkjd");


            //Nom du compte client auquel l'utilisateur appartient
            Console.WriteLine(conjurClientDave.GetAccountName());
           //Nombre de var = 1 
            Console.WriteLine(conjurClientDave.CountVariables().ToString());
            //get value of secret var entered in Conjur = "thisIsASecret
            Console.WriteLine(conjurClientDave.ListVariables().First().GetValue());
     
           








        }
    }
}
