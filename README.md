# Relatórios com FastReport


[![C#](https://img.shields.io/badge/C%23-blue)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![FastReport](https://img.shields.io/badge/FastReport-darkred)](https://www.fast-report.com/en/)
[![FastReport](https://img.shields.io/badge/FastReport%20OpenSource-red)](https://fastreports.github.io/FastReport.Documentation/)

Este repositório apresenta exemplos de relatórios gerados com o FastReport em um projeto Windows Forms C#. Três exemplos são fornecidos para demonstrar diferentes abordagens na criação de relatórios.

## Exemplos de Relatórios

### 1. Utilização com Parâmetros
Este é um modelo simples, onde os parâmetros são definidos no Designer do FastReport e podem ser facilmente preenchidos usando o método `SetParameterValue(NomeDoParâmetro, Valor)`.

### 2. Utilização de Fonte de Dados DataTable
O segundo relatório utiliza um tipo de fonte de dados do tipo tabela (`<TableDataSource/>`). Para usar este tipo, é necessário garantir que os dados fornecidos sejam do tipo DataTable no C#. Isso é alcançado com o método `RegisterData(Tabela, NomeDaTabela)`.

### 3. Utilização de Coleções
O terceiro exemplo é semelhante ao segundo, mas utiliza uma fonte de dados do tipo coleção (`<BusinessObjectDataSource/>`). Isso permite que o DataSource receba coleções em vez de tabelas.

---

Os três relatórios fornecidos neste repositório são exemplos simples que demonstram três características principais de geração de relatórios com FastReport. Embora estes exemplos sejam básicos, eles fornecem uma base sólida para explorar diversas maneiras de criar e personalizar relatórios em projetos Windows Forms C#. Vale ressaltar que existem muitas outras opções disponíveis, como integrar diretamente com recursos de bases de dados sem a necessidade de alterar manualmente as tags de configuração. No entanto, esses três modelos oferecem um controle maior sobre o que está sendo montado para receber dados, o que pode ser útil em diferentes cenários de desenvolvimento.

