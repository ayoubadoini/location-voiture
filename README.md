# Location de Voitures

Application de gestion d’une agence de location de voitures développée en C# avec Windows Forms.

## Objectif

Ce projet permet de gérer :
- les clients,
- les voitures,
- les locations,
- la consultation des données depuis une interface utilisateur simple.

Il s’agit d’une application desktop sous .NET Framework, conçue pour fonctionner avec une base de données SQL Server LocalDB.

## Fonctionnalités

- Ajouter, modifier et supprimer des clients
- Ajouter, modifier et supprimer des voitures
- Enregistrer des locations de voitures
- Calcul automatique du prix total selon la durée de location
- Affichage des données dans des tableaux
- Navigation via un tableau de bord principal

## Stack technique

- Langage : C#
- Framework : .NET Framework 4.7.2
- Interface : Windows Forms (WinForms)
- Base de données : SQL Server LocalDB
- Accès aux données : ADO.NET

## Structure du projet

- `Program.cs` : point d’entrée de l’application
- `Dashboard.cs` : écran principal de navigation
- `FormClient.cs` : gestion des clients
- `FormVoiture.cs` : gestion des voitures
- `FormLocation.cs` : gestion des locations
- `ado/` : classes d’accès aux données (CRUD)
- `entities/` : classes métier (`Client`, `Voiture`, `Location`)
- `Properties/` : paramètres et ressources du projet

## Base de données

La connexion est configurée dans :
- `ado/Connexion.cs`

La chaîne de connexion actuelle pointe vers :
- `Data Source=(localdb)\MSSQLLocalDB`
- `Initial Catalog=location_voiture`

Assurez-vous que la base `location_voiture` existe et contient les tables suivantes :
- `Client`
- `Voiture`
- `Location`

## Prérequis

- Visual Studio 2019 ou plus
- .NET Framework 4.7.2
- SQL Server LocalDB
- Accès local aux bases SQL Server

## Lancer le projet

1. Ouvrir la solution `ProjetC#.sln` dans Visual Studio.
2. Vérifier la connexion SQL Server LocalDB.
3. Compiler puis lancer le projet.

## Exemple de workflow

1. Ajouter un client.
2. Ajouter une voiture disponible.
3. Créer une location avec :
   - client,
   - véhicule,
   - dates de début et fin,
   - état de la location.
4. Le système calcule automatiquement le montant total.

## Auteur

Projet réalisé dans le cadre d’un travail de développement C# / gestion de location de voiture.
