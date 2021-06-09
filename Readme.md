# blogpostTest
## MVC and API .Net Core Visual Studio solution

## Development time (14 hours)

## Requirements
 - Sql server 2014
 - Visual Studio

## Features

- Crud for blog post and users
- API for query content of published post

## Tech
- MVC .Net Core template.
- EntityFramework Core for CRUD Model, controller and views.

## Installation

```sh
git clone https://github.com/neojavan/blogpostTest
```
## Database
Import the sql file into your database. You could do it on Sql Server Management Studio or by cmd with admin privilege

## Project
Publish the solution from the visual studio to your local IIS or Azure

## Endpoints

- // GET: api/Posts 
Query the posts pending of being published
status
1 submit pending
2 reject
3 publish
4 delete
