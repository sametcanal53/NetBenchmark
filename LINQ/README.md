# LINQ Benchmarking Project

## 🌐 Project Overview
This LINQ Benchmarking project is focusing on measuring and comparing LINQ (Language Integrated Query) method performances across different .NET runtime versions

### 🔍 Detailed LINQ Method Performance Analysis
- Measures performance of over 40 different LINQ methods
- Comparison across different data sizes (100, 1,000, 10,000 items)
- Testing across multiple .NET runtime versions

## 🛠️ Installation
```bash
# Clone the entire project
git clone https://github.com/sametcanal53/NetBenchmark.git

# Navigate to project directory
cd NetBenchmark

# Install required dependencies
dotnet restore

# Run the project
dotnet run -c Release --framework net9.0 (or any other .NET versions (net5.0, net6.0, net7.0, net8.0))
```
 
### 📊 Rich Reporting Formats
- ASCII Doc
- CSV
- HTML
- JSON
- Markdown
- XML
- R Plot

### 🚀 Performance Metrics
- Time performance
- Memory usage
- Comparisons across different .NET versions

## 📋 Usage
The project automatically runs performance tests for all LINQ methods. Results are displayed in console output and selected report formats

## 🔬 Tested LINQ Methods
- Aggregate
- All
- Any
- Append
- Average
- Cast
- Concat
- Contains
- Count
- DefaultIfEmpty
- Distinct
- ElementAt
- Except
- First
- GroupBy
- Join
- Max
- Min
- OrderBy
- Select
- Where and many more...
