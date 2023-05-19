# ContactManagement
É um aplicativo web de controle de lista de contatos desenvolvido em Razor!
## Rodando a aplicação

### Clone o repositório
```bash
git clone https://github.com/Jpereira29/ContactManagement.git
```

### Entre na pasta do projeto
```bash
cd .\ContactManagement\ContactManagement
```
### Antes de rodar a aplicação faça a seguite alteração
altere o usuário e senha da string de conexão para seu usuário:
```bash
[arquivo appsettings.json]
"ConexãoString": {
"MariaDB": "Servidor=10.25.3.19;DataBase=db;Uid=root;Pwd=root;"
}
```

### Populando as tabelas
```bash
dotnet ef database update
```

### Rode o projeto
```bash
dotnet run
```
<a href="https://localhost:7150">Teste</a>
