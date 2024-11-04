# SalesManagementWebMvcSystem

Este projeto é um sistema de controle de vendas desenvolvido em C# com ASP.NET Core MVC. Ele permite administrar informações relacionadas a vendedores, departamentos e registros de vendas, armazenados em um banco de dados SQL Server.

## 💻 Descrição

O sistema foi projetado para auxiliar na gestão de vendas e permite ao usuário visualizar e manipular informações de vendedores, departamentos e registros de vendas, com funcionalidades para adicionar, remover e calcular o total de vendas em períodos específicos.

## 🔮 Funcionalidades

- **Cadastro de Vendedores e Departamentos**: Permite cadastrar, editar e remover vendedores e departamentos.
- **Registro de Vendas**: Possibilita o gerenciamento de registros de vendas, com status como pendente, faturado e cancelado.
- **Cálculo de Vendas**: Permite calcular o total de vendas de um vendedor ou de um departamento em intervalos de datas específicos.

## 📊 Estrutura das Entidades

### Department (Departamento)

- **Atributos**: `Id`, `Name`
- **Métodos**:
  - `addSeller(seller: Seller)`: Adiciona um vendedor ao departamento.
  - `totalSales(initial: Date, final: Date)`: Calcula o total de vendas dos vendedores no departamento em um intervalo de datas.

### Seller (Vendedor)

- **Atributos**: `Id`, `Name`, `Email`, `BirthDate`, `BaseSalary`
- **Métodos**:
  - `addSales(sr: SalesRecord)`: Adiciona um registro de venda ao vendedor.
  - `removeSales(sr: SalesRecord)`: Remove um registro de venda do vendedor.
  - `totalSales(initial: Date, final: Date)`: Calcula o total de vendas em um intervalo de datas.

### SalesRecord (Registro de Venda)

- **Atributos**: `Id`, `Date`, `Amount`, `Status`
- **Status**: Utiliza uma enumeração `SaleStatus` que define três estados: `PENDING`, `BILLED` e `CANCELED`.

## 🛠️ Tecnologias Utilizadas

- **C#**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**

## 📂 Estrutura do Banco de Dados

As entidades `Department`, `Seller` e `SalesRecord` são mapeadas para tabelas no SQL Server, facilitando a persistência e manipulação dos dados de vendas.

## 🚀 Configuração do Ambiente

1. Clone o repositório:

   ```bash
   git clone https://github.com/Brendon3578/SalesManagementWebMvcSystem.git
   ```

2. Configure a string de conexão para o SQL Server no `appsettings.json`.

3. Execute as migrações para criar as tabelas no banco de dados:

   ```bash
   dotnet ef database update
   ```

4. Inicie a aplicação:

   ```bash
   dotnet run
   ```

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
