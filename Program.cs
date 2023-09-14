using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Core;
using System;
using System.Text;
using Microsoft.Data.SqlClient;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
SecretClientOptions options = new SecretClientOptions()
    {
        Retry =
        {
            Delay= TimeSpan.FromSeconds(2),
            MaxDelay = TimeSpan.FromSeconds(16),
            MaxRetries = 5,
            Mode = RetryMode.Exponential
         }
    };
var client = new SecretClient(new Uri("https://shreya-kv.vault.azure.net/"), new DefaultAzureCredential(),options);
// or if accessing the keyvault reference use the Configuration.Get () method
KeyVaultSecret secret = client.GetSecret("shreya-shah-1");
string str="";
string secretValue = secret.Value;
 
try 
            { 
                SqlConnectionStringBuilder builder2 = new SqlConnectionStringBuilder();
                builder2.DataSource = "shreya-db-server.database.windows.net"; 
                builder2.UserID = "shreya";            
                builder2.Password = secretValue;     
                builder2.InitialCatalog = "shreya-db";

                using (SqlConnection connection = new SqlConnection(builder2.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT * FROM inventory";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { var i = 0;
                          
                            while (reader.Read() )
                            {
                               Console.WriteLine(string.Format(
                         "Reading from table=({0},{1})",
                    reader.GetString(0),reader.GetInt32(1)));
                    str=str+"\n"+string.Format(
                         "Reading from table=({0},{1})",
                    reader.GetString(0),reader.GetInt32(1));
                    
                         
                            }
                            
                        }
                        connection.Close();
                    }                    
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                    
              
            }

app.MapGet("/", () => str);
app.Run();
