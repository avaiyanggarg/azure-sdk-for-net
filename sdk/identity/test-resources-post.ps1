param (
    [hashtable] $DeploymentOutputs
    # [string] $TenantId,
    # [string] $TestApplicationId,
    # [string] $TestApplicationSecret
)

Write-Host $DeploymentOutputs['IDENTITY_WEBAPP_USER_DEFINED_IDENTITY']
Write-Host $DeploymentOutputs['IDENTITY_STORAGE_NAME_2']
dotnet publish ./sdk/identity/Azure.Identity/integration/WebApp/Integration.Identity.WebApp.csproj -o ./sdk/identity/Azure.Identity/integration/WebApp/Pub
Compress-Archive -Path ./sdk/identity/Azure.Identity/integration/WebApp/Pub/* -DestinationPath ./sdk/identity/Azure.Identity/integration/WebApp/Pub/package.zip  -Force
az webapp deploy --resource-group $DeploymentOutputs['IDENTITY_RESOURCE_GROUP'] --name $DeploymentOutputs['IDENTITY_WEBAPP_NAME'] --src-path ./sdk/identity/Azure.Identity/integration/WebApp/Pub/package.zip
rd -Force -Recurse ./sdk/identity/Azure.Identity/integration/WebApp/Pub
