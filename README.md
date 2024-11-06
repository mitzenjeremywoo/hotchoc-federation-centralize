
product

dotnet fusion subgraph config set http --url http://localhost:5051


please remember to edit and update your schema name
subgraph-config.json 

{"subgraph":"accounts","http":{"baseAddress":"http://localhost:5054/"}}


before trying to export and compose it

dotnet run -- schema export --output schema.graphql

dotnet fusion subgraph pack

dotnet fusion compose -p .\gateway\gateway.zip -s .\accounts\


----------------------------------------------------------------

inventory 


dotnet fusion subgraph config set http --url http://localhost:5052

please remember to edit and update your schema name
subgraph-config.json 

{"subgraph":"inventory","http":{"baseAddress":"http://localhost:5054/"}}

before trying to export and compose it

dotnet run -- schema export --output schema.graphql

dotnet fusion subgraph pack

dotnet fusion compose -p .\gateway\gateway.zip -s .\Inventory\



---------------------------------------------------------------

products 

 
dotnet fusion subgraph config set http --url http://localhost:5053

dotnet run -- schema export --output schema.graphql

dotnet fusion subgraph pack

dotnet fusion compose -p .\gateway\gateway.zip -s .\products\


---------------------------------------------------------------
reviews 
dotnet fusion subgraph config set http --url http://localhost:5054

dotnet run -- schema export --output schema.graphql

dotnet fusion subgraph pack

dotnet fusion compose -p .\gateway\gateway.zip -s .\reviews\

please remember to edit and update your schema name
subgraph-config.json 

{"subgraph":"reviews","http":{"baseAddress":"http://localhost:5054/"}}


