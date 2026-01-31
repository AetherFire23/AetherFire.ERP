
# Projet is the pratical asssembly since it's containing the ef core context 
dotnet ef migrations add "initial $([Guid]::NewGuid().ToString())" --project "../ERP.Practical";





