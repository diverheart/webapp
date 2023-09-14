# Overview
A codebase of a .NET app that lets you use an Azure keyvault variable to connect to Azure SQL databse

# Prequisites

1) Make sure you have created the SQL database and keyvault with the password stored in the keyvault
2) Make sure you have some data stored in your SQL (Can use data studio)
3) Make sure you have dotnet SDK installed
4) Make sure you have nuget package Microsoft.Data.SqlClient installed


# Steps

1) This assumes you have a (varchar,int32) format table created in your SQL database
2) Please update the required values in Program.cs file
3) Please run the following command to verify in localhost 

```
dotnet run
```




# For Deployment
For deployment of this C# App to Webapp
its more convenient to store it in an local git repo for the webapp
Please create the webapp using the following command

```
az webapp create --resource-group "myResourceGroup" --plan "myAppServicePlan" --name "<your-webapp-name>" --deployment-local-git
```

The URL of the Git remote is shown in the deploymentLocalGitUrl property, in the format https://<username>@<your-webapp-name>.scm.azurewebsites.net/<your-webapp-name>.git. Save this URL. You'll need it later.

Now configure your web app to deploy from the main branch:

```
az webapp config appsettings set -g MyResourceGroup --name "<your-webapp-name>" --settings deployment_branch=main
```

Now run the following commands to deploy the .NET app to Webapp

```
git add .
git commit -m "first commit"
git remote add azure <deploymentLocalGitUrl-from-create-step>
git push azure main
```

Your app should be up and running now at 
```
http://<your-webapp-name>.azurewebsites.net
```
