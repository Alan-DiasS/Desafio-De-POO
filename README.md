# 📱 Desafio POO — Smartphones (Nokia e iPhone)

## 📌 Sobre o Projeto  
Este projeto foi desenvolvido como parte do desafio de **Programação Orientada a Objetos (POO)** em C#.  
O objetivo é **implementar uma hierarquia de classes** que represente **smartphones**, aplicando conceitos de **herança, abstração e polimorfismo**.  

Foram criadas as classes:  
- 📱 **Smartphone** (classe abstrata)  
- 🍏 **Iphone** (herda de Smartphone)  
- 📞 **Nokia** (herda de Smartphone)

---

## 🛠️ Tecnologias Utilizadas  
- 🔹 .NET 6  
- 🔹 C#  
- 🔹 Programação Orientada a Objetos (POO)  

---

## 📂 Estrutura do Projeto  
```bash
📦 DesafioPOO
 ┣ 📂 Models
 ┃ ┣ 📜 Smartphone.cs
 ┃ ┣ 📜 Iphone.cs
 ┃ ┗ 📜 Nokia.cs
 ┣ 📜 Program.cs
 ┗ 📜 README.md
```
## 🚀 Como Executar
1️⃣ Clone o repositório:
```bash
git clone https://github.com/seu-usuario/DesafioPOO.git
```
2️⃣ Acesse a pasta do projeto:
````bash
cd DesafioPOO
````
3️⃣ Execute o projeto:
````bash
dotnet run
````
## 🧑‍💻 Exemplo de Uso
````bash
using DesafioPOO.Models;

Iphone iphone = new Iphone("123456", "iPhone 13", "111111111111111", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("789101", "Nokia Tijolão", "222222222222222", 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
````
## ✅ Funcionalidades
- 📲 Fazer e receber ligações
- 📂 Instalar aplicativos
- 🔋 Definir diferentes modelos de smartphones
- 🏗️ Aplicação de abstração, herança e polimorfismo
---
