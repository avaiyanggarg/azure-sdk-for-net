param (
    [hashtable] $DeploymentOutputs
    # [string] $TenantId,
    # [string] $TestApplicationId,
    # [string] $TestApplicationSecret
)

Write-Host $DeploymentOutputs['IDENTITY_WEBAPP_USER_DEFINED_IDENTITY']
Write-Host $DeploymentOutputs['IDENTITY_STORAGE_NAME_2']
md -Force ./artifacts/bin/Integration.Identity.WebApp/Pub
dotnet publish ./sdk/identity/Azure.Identity/integration/WebApp/Integration.Identity.WebApp.csproj -o ./artifacts/bin/Integration.Identity.WebApp/Pub
Compress-Archive -Path ./artifacts/bin/Integration.Identity.WebApp/Pub/* -DestinationPath ./artifacts/bin/Integration.Identity.WebApp/Pub/package.zip  -Force
az webapp deploy --resource-group $DeploymentOutputs['IDENTITY_RESOURCE_GROUP'] --name $DeploymentOutputs['IDENTITY_WEBAPP_NAME'] --src-path ./artifacts/bin/Integration.Identity.WebApp/Pub/package.zip
