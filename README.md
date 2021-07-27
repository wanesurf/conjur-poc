# conjur-poc 

In is POC we create a Conjur OSS environment and retrieve a secret from Conjur from a .Net Framework 4.5 Console application.

Quick start setting up Conjur OSS environment with Docker : https://www.conjur.org/get-started/
About Conjur OSS : https://docs.conjur.org/Latest/en/Content/Overview/Conjur-OSS-Suite-Overview.html

# Conjur Dotnet API and CLI Documentation 
Refer to for more information :https://www.conjur.org/get-started/quick-start/oss-environment/ and 


| Use case        | Dotnet API           | Conjur CLI  |
| ------------- |:-------------:| -----:|
| Create/initialize a client       | Client Client(uri, account) | / |
| Login to Conjur user      | void client.LogIn(string userName, string password)      |   / |
| Add Conjur root certificate to system trust store    | client.TrustedCertificates.ImportPem (string certPath) |   / |
| List Conjur variables     | IEnumerable<Variable> client.ListVariables(string query = null)      |   / |
| Create an host | Host client.CreateHost(string name, string hostFactoryToken)      |   In policy.yml |
| Create a Conjur policy object     | Policy client.Policy(string policyName)      |   / |
|Load policy into Conjur     | policy.LoadPolicy(Stream policyContent)      |   / |
| Instantiate a Variable object      | Variable client.Variable(string name)      |   / |
| Check if the current client/entity has the specified privilege on this variable | Boolean variable.Check(string privilege)      |   / |
| Add secret to variable | void variable.AddSecret(bytes val)|    / |
| String variable.GetValue() | Return the value of the current Variable    |    / |



## Conjur Policy 
refer to for more information : https://docs.conjur.org/Latest/en/Content/Operations/Policy/policy-overview.htm
\
//TODO tab with infos