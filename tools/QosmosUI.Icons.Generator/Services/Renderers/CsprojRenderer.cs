// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Renderers;

/// <summary>
/// Generates a .csproj file for a Blazor component library based on a predefined template.
/// </summary>
public sealed class CsprojRenderer : ICsprojRenderer
{
    /// <summary>
    /// Template for the .csproj file, containing placeholders for dynamic values.
    /// </summary>
    private const string Template =
        """
        <Project Sdk="Microsoft.NET.Sdk.Razor">

          <PropertyGroup>
            <TargetFramework>net9.0</TargetFramework>
            <Nullable>enable</Nullable>
            <ImplicitUsings>enable</ImplicitUsings>
            <Version>1.0.1</Version>
            <IsAotCompatible>true</IsAotCompatible>
            <PackageLicenseExpression>MIT</PackageLicenseExpression>
            <PackageId>%Namespace%</PackageId>
            <PackageIcon>QosmosUI.png</PackageIcon>
            <Authors>AerafalGit</Authors>
            <Company>QosmosUI</Company>
            <Copyright>Copyright 2025 QosmosUI</Copyright>
            <PackageTags>Blazor, BlazorServer, BlazorWebAssembly, Components, Icons</PackageTags>
            <Description>A comprehensive and high-performance icon library for Blazor, inspired by react-icons.</Description>
            <PackageProjectUrl>https://github.com/QosmosUI/QosmosUI.Icons</PackageProjectUrl>
            <PackageReadmeFile>README.md</PackageReadmeFile>
            <RepositoryUrl>https://github.com/QosmosUI/QosmosUI.Icons</RepositoryUrl>
            <RepositoryType>git</RepositoryType>
          </PropertyGroup>

          <PropertyGroup>
            <GeneratePackageOnBuild>false</GeneratePackageOnBuild>
            <GenerateDocumentationFile>false</GenerateDocumentationFile>
            <PackageRequireLicenseAcceptance>true</PackageRequireLicenseAcceptance>
          </PropertyGroup>

          <ItemGroup>
            <None Include="..\..\LICENSE" Pack="true" Visible="false" PackagePath="" />
            <None Include="..\..\README.md" Pack="true" Visible="false" PackagePath="" />
            <None Include="..\..\QosmosUI.png" Pack="true" Visible="false" PackagePath="" />
          </ItemGroup>

          <ItemGroup>
            <SupportedPlatform Include="browser"/>
          </ItemGroup>

          <ItemGroup>
            <PackageReference Include="Microsoft.AspNetCore.Components.Web" Version="9.0.4"/>
          </ItemGroup>

        </Project>
        """;

    /// <summary>
    /// Generates a project file based on the provided icon metadata.
    /// </summary>
    /// <param name="metadata">The metadata of the icon, including its name and other properties.</param>
    /// <returns>A string containing the generated project file content.</returns>
    public string GenerateProject(IconMetadata metadata)
    {
        // Replace the %Namespace% placeholder in the template with the icon's name from the metadata.
        return Template.Replace("%Namespace%", string.Concat("QosmosUI", '.', "Icons", '.', metadata.Name));
    }
}
