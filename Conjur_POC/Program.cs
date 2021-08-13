using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Conjur;

namespace Conjur_POC
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            string variableId = "secretSimon";
            string variableId2 = "dotnetAPISecret98";


            //retrieve clients created with CLI (policy)
            Client conjurClientDave = new Client("http://localhost:8080", "myConjurAccount");
            //Login as Dave (human)3tqnbp0q3az402gv3m9736gj32j17vhxa96amqay31w9xaq1zmx3pk
            conjurClientDave.LogIn("Dave@BotApp", "");

            Client admin = new Client("https://conjur-oss-conjur.apps.pwclabokd.io", "conjurAdm");
            admin.LogIn("admin", "7g60tt11vkefyqsxce2v6gwc6qtxyaasvjmpx36qd70v1nfbyf2");



            //Load policy to root with request variable Id

            Policy policy = admin.Policy("root");
            using (MemoryStream ms = new MemoryStream())
            {

                using (StreamWriter sw = new StreamWriter(ms))
                {

                    sw.WriteLine("- !variable");
                    sw.WriteLine($"  id: {variableId}");
                    sw.WriteLine("- !variable");
                    sw.WriteLine($"  id: {variableId2}");
                    sw.Flush();
                    Stream policyOutputStream = policy.LoadPolicy(ms);
                    using (StreamReader reader = new StreamReader(policyOutputStream))
                    {
                        string policyLoadOutput = reader.ReadToEnd();
                        Console.WriteLine("Policy load successuly output: '{0}'", policyLoadOutput);
                    }
                }
            }

            //variable creation
             Variable conjurVariable = admin.Variable("secretSimon");
            //adding secret
             conjurVariable.AddSecret(Encoding.ASCII.GetBytes("thisIsANewSecretFromSimon"));
            //show secret
            Console.WriteLine(conjurVariable.GetValue());



            //Nom du compte client auquel l'utilisateur appartient
            Console.WriteLine(admin.GetAccountName());
           //Nombre de var = 1 
            Console.WriteLine(admin.CountVariables().ToString());
            //get value of secret var entered in Conjur = "thisIsASecretFromCLI")
            Console.WriteLine(admin.ListVariables().First().GetValue());
            Console.WriteLine(admin.ListVariables("secretVar").First().GetValue());










        }
    }
}
