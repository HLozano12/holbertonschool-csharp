#!/usr/bin/env bash
# script that initializes, builds, and runs a new C# project from
# a folder titled 2-new_project


dotnet new console -n 2-new_project
dotnet build 2-new_project
dotnet run 2-new_project
