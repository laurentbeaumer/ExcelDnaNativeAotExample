This project is a to prove that ExcelDNA is not currently supporting Native AOT (stable version is 1.8.0)

1. Run "publish.bat ExcelDnaNativeAotExample.sln" in command window
2. Build or Run the solution in VS 2022 using "Release" and "AnyCPU"
3. Open Excel, and type in a cell the formula: =SayHello()
4. The function return "#VALUE". If the solution is run as "Debug", the function works and displays "Say Hello".


