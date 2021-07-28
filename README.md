# conjur-poc 

In is POC we create a Conjur OSS environment and retrieve a secret from Conjur from a .Net Framework 4.5 Console application.

Quick start setting up Conjur OSS environment with Docker : https://www.conjur.org/get-started/
About Conjur OSS : https://docs.conjur.org/Latest/en/Content/Overview/Conjur-OSS-Suite-Overview.html

# Conjur Dotnet API and CLI Documentation 
Refer to for more information :https://www.conjur.org/get-started/quick-start/oss-environment/ and https://github.com/cyberark/conjur-api-dotnet


| Use case        | Dotnet API           | Conjur CLI  |
| ------------- |:-------------:| -----:|
| Create/initialize a client       | Client Client(uri, account) | access the right container |
| Login to Conjur user      | void client.LogIn(string userName, string password)      |   conjur authn login -u user |
| Add Conjur root certificate to system trust store    | client.TrustedCertificates.ImportPem (string certPath) |   / |
| List Conjur variables     | IEnumerable<Variable> client.ListVariables(string query = null)      |   conjur list  |
| Create an host | Host client.CreateHost(string name, string hostFactoryToken)      |   In policy.yml |
| Create a Conjur policy object     | Policy client.Policy(string policyName)      |   / |
|Load policy into Conjur     | policy.LoadPolicy(Stream policyContent)      |  conjur policy load root policy/nameOfFile.yml > nameOfFileThatWillBeGenerated |
| Instantiate a Variable object      | Variable client.Variable(string name)      |   / |
| Check if the current client/entity has the specified privilege on this variable | Boolean variable.Check(string privilege)      |   / |
| Add secret to variable | void variable.AddSecret(bytes val)|  conjur variable values add variableName "secretAsAString" |
| String variable.GetValue() | Return the value of the current Variable    |    / |



## Conjur Policy 
refer to for more information : https://docs.conjur.org/Latest/en/Content/Operations/Policy/policy-overview.htm
\
<table class="TableStyle-Standard" style="mc-table-style: url('../../Resources/TableStyles/Standard.css');" cellspacing="0">
                                                                    <thead>
                                                                        <tr class="TableStyle-Standard-Head-Header1">
                                                                            <th class="TableStyle-Standard-HeadE-Column1-Header1" scope="col"><b>Topic</b>
                                                                            </th>
                                                                            <th colspan="5" class="TableStyle-Standard-HeadD-Column1-Header1" scope="col"><b>Relevant Policy Statements</b>
                                                                            </th>
                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><b>Manage Policy</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-policy.htm#Policy" class="MCXref xref">Policy</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-permit.htm#Permit" class="MCXref xref">Permit</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-deny.htm#Deny" class="MCXref xref">Deny</a>
                                                                            </td>
                                                                            <td colspan="2" class="TableStyle-Standard-BodyD-Column1-Body1">&nbsp;</td>
                                                                        </tr>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><b>Manage Users</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-user.htm#User" class="MCXref xref">User</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-group.htm#Group" class="MCXref xref">Group</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-grant.htm#Grant" class="MCXref xref">Grant</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-revoke.htm#Revoke" class="MCXref xref">Revoke</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyD-Column1-Body1">&nbsp;</td>
                                                                        </tr>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><b>Manage Machines</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-host.htm#Host" class="MCXref xref">Host</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-layer.htm#Layer" class="MCXref xref">Layer</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="statement-ref-grant.htm#Grant" class="MCXref xref">Grant</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-revoke.htm#Revoke" class="MCXref xref">Revoke</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyD-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-host-factory.htm#Host-fac" class="MCXref xref">Host-factory</a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><b>Manage Secrets</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-variable.htm#Variable" class="MCXref xref">Variable</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-permit.htm#Permit" class="MCXref xref">Permit</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-deny.htm#Deny" class="MCXref xref">Deny</a>
                                                                            </td>
                                                                            <td colspan="2" class="TableStyle-Standard-BodyD-Column1-Body1">&nbsp;</td>
                                                                        </tr>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><b>Manage DB Records</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyE-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-delete.htm#Delete" class="MCXref xref">Delete</a>
                                                                            </td>
                                                                            <td colspan="4" class="TableStyle-Standard-BodyD-Column1-Body1">&nbsp;</td>
                                                                        </tr>
                                                                        <tr class="TableStyle-Standard-Body-Body1">
                                                                            <td class="TableStyle-Standard-BodyB-Column1-Body1"><b>Special Services</b>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyB-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-webservice.htm#Webservi" class="MCXref xref">Webservice</a>
                                                                            </td>
                                                                            <td class="TableStyle-Standard-BodyB-Column1-Body1"><a href="https://docs.conjur.org/Latest/en/Content/Operations/Policy/statement-ref-permit.htm#Permit" class="MCXref xref">Permit</a>
                                                                            </td>
                                                                            <td colspan="3" class="TableStyle-Standard-BodyA-Column1-Body1">&nbsp;</td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
  
  Exemple of policy : https://github.com/cyberark/conjur-quickstart/blob/main/conf/policy/BotApp.yml
