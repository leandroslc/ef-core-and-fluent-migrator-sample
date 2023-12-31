Other languages: [pt-BR](./docs/README.pt-BR.md)

<div align="center">
  <h1>EF Core and Fluent Migrator (Sample)</h1>
  <img src="./docs/sample.png" alt="Sample output" />
</div>

## :book: Purpose
A sample application to show how to easily setup a database with [EF Core](https://learn.microsoft.com/ef/core) and [Fluent Migrator](https://fluentmigrator.github.io).

## :package: Requirements
- Make sure you have [.NET SDK version 7](https://dotnet.microsoft.com).
- Make sure you have [docker and docker compose](https://www.docker.com/get-started).

## :rocket: Running the sample
- Start the database by running `docker compose up -d`.
- Navigate to the sample project: `cd src/Sample`.
- Run `dotnet run`.

## :memo: Notes
- This sample uses PostgreSQL, but it can be easily adapted to use any database provider.
